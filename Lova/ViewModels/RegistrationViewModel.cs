using Models.Commands;
using Models.Contexts;
using Models.Models;
using Models.UnitOfWork;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            get { return confirmedPassword; }
            set
            {
                confirmedPassword = value;
                OnPropertyChanged("ConfirmedPassword");
            }
        }

        public ICommand SignUpCommand => new RelayCommand(obj => CanSignUp());

        private async void CanSignUp()
        {
            if (unitOfWork.UserRepository.Get().FirstOrDefault(user => user.UserName == UserName) != null)
            {
                MessageBox.Show("User has already existed");
                return;
            }

            if (CheckField())
            {
                var newUser = new User()
                {
                    UserName = userName,
                    Password = password,
                };
                await unitOfWork.UserRepository.AddAsync(newUser);                   
            }
        }

        private bool CheckField()
        {
            Regex regexLogin = new Regex(@"^[A-zА-я\d]+$");
            Regex regexPassword = new Regex(@"^[A-Za-z\d]+$");

            if (!regexLogin.IsMatch(UserName))
            {
                MessageBox.Show("Login is not validated");
                return false;
            }

            else if (!regexPassword.IsMatch(Password) || Password.Length < 6)
            {
                MessageBox.Show("Password is not validated");
                return false;
            }

            else if (Password != ConfirmedPassword)
            {
                MessageBox.Show("Confirmed Password is not equal to Password");
                return false;
            }

            else
            {
                return true;
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
    }
}
