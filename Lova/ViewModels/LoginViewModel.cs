using Lova;
using Models.Commands;
using Models.Current;
using Models.UnitOfWork;
using Models.Validation;
using Presentation.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string userName;
        private string password;

        public ICommand LoginCommand => new RelayCommand(obj => Login());
        public ICommand GoToRegistrationCommand => new RelayCommand(obj => GoToRegistration());

        public LoginViewModel()
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

        private void Login()
        {
            var currentUser = unitOfWork.UserRepository.Get().FirstOrDefault(user => user.UserName == UserName);
            if (currentUser != null)
            {
                if (Validation.GetHashString(Password) == currentUser.Password)
                {
                    CurrentUser.SetUserId(currentUser.Id);

                    App.ForumPage = new ForumView();
                    App.ProfilViewModel.CurrentPage = App.ForumPage;
                }
                else
                {
                    MessageBox.Show("Пароль введен с ошибкой, попробуйте ещё раз :)");
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует или логин введен с ошибкой, попробуйте ещё раз :)");
            }
        }

        private void GoToRegistration()
        {
            App.RegistrationPage = new RegistrationView();
            App.ProfilViewModel.CurrentPage = App.RegistrationPage;
        }
    }
}
