using Models.CurrentUser;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;

namespace Presentation.ViewModels
{
    public class UserTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<UserTest> userTests;

        public UserTestViewModel()
        {
            unitOfWork = new UnitOfWork();

            userTests = new ObservableCollection<UserTest>(unitOfWork.UserTestRepository.GetUserTestByUserId(CurrentUser.GetUserId()));
        }

        public ObservableCollection<UserTest> UserTests 
        {
            get => userTests;
            set
            {
                userTests = value;
                OnPropertyChanged("UserTests");
            }
        }

    }
}
