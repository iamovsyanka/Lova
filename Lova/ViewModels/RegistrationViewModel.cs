using Lova;
using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using Models.Validation;
using Presentation.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class RegistrationViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string userName;
        private string password;
        private string confirmedPassword;

        public ICommand SignUpCommand => new RelayCommand(obj => SignUp());
        public ICommand GoToLoginCommand => new RelayCommand(obj => GoToLogin());

        public RegistrationViewModel()
        {
            unitOfWork = new UnitOfWork();
        }

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string Password
        {
            private get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public string ConfirmedPassword
        {
            private get => confirmedPassword;
            set
            {
                confirmedPassword = value;
                OnPropertyChanged("ConfirmedPassword");
            }
        }

        public string Img
        {
            get
            {
                var random = new Random();
                switch (random.Next(6))
                {
                    case 0:
                        return "..\\Views\\Resource\\Image\\User0.png";
                    case 1:
                        return "..\\Views\\Resource\\Image\\User1.png";
                    case 2:
                        return "..\\Views\\Resource\\Image\\User2.png";
                    case 3:
                        return "..\\Views\\Resource\\Image\\User3.png";
                    case 4:
                        return "..\\Views\\Resource\\Image\\User4.png";
                    case 5:
                        return "..\\Views\\Resource\\Image\\User5.png";
                    default:
                        return "..\\Views\\Resource\\Image\\User0.png";
                }
            }
        }

        private async void SignUp()
        {
            if (unitOfWork.UserRepository.Get().FirstOrDefault(user => user.UserName == UserName) != null)
            {
                MessageBox.Show("Упс... Пользователь с таким именем уже существует :)");
                return;
            }

            if (CheckField())
            {
                var newUser = new User()
                {
                    UserName = userName,
                    Password = Validation.GetHashString(password),
                    Role = Models.Enums.Role.User
                };
                await unitOfWork.UserRepository.AddAsync(newUser);

                MessageBox.Show("Регистрация прошла успешно! :)\nДля дальнейшей работы авторизируйтесь");

                App.LoginPage = new LoginView();
                App.ProfilViewModel.CurrentPage = App.LoginPage;
            }
        }

        private bool CheckField()
        {
            if (!Validation.regexLogin.IsMatch(UserName))
            {
                MessageBox.Show("Логин может содержать только цифры и буквы :)");
                return false;
            }

            else if(UserName.Length < 4)
            {
                MessageBox.Show("Логин должен содержать более 4 символов :)");
                return false;
            }

            else if (!Validation.regexPassword.IsMatch(Password))
            {
                MessageBox.Show("Пароль может содержать только цифры и буквы латинского алфавита :)");
                return false;
            }

            else if (Password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать более 6 символов :)");
                return false;
            }

            else if (Password != ConfirmedPassword)
            {
                MessageBox.Show("Пароли не совпадают, попробуйте ещё :)");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void GoToLogin()
        {
            App.LoginPage = new LoginView();
            App.ProfilViewModel.CurrentPage = App.LoginPage;
        }
    }
}
