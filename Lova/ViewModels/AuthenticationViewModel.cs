using Models.Commands;
using Models.CurrentUser;
using Models.UnitOfWork;
using Presentation.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class AuthenticationViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string userName;
        private string password;

        public ICommand LoginCommand => new RelayCommand(obj => CanLogin());

        public AuthenticationViewModel()
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

        private void CanLogin()
        {
            var currentUser = unitOfWork.UserRepository.Get().FirstOrDefault(user => user.UserName == UserName);
            if (currentUser != null)
            {
                if (Password == currentUser.Password)
                {
                    CurrentUser.SetUserId(currentUser.Id);
                    var profil = new Profil();
                    profil.Show();
                }
                else
                {
                    MessageBox.Show("Login or Password isn't correctly");
                }
            }
            else
            {
                MessageBox.Show("Login or Password isn't correctly");
            }
        }
    }
}
