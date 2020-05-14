using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class UsersTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<UserTest> userTests;

        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());
        public ICommand GoToCalculatorCommand => new RelayCommand(obj => GoToCalculator());

        public UsersTestViewModel()
        {
            unitOfWork = new UnitOfWork();
            userTests = new ObservableCollection<UserTest>(unitOfWork.UserTestRepository.Get());
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

        private void GoToForum()
        {
            App.ForumPage = new Views.ForumView();
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }

        private void GoToTest()
        {
            App.TestsPage = new Views.TestsView();
            App.ProfilViewModel.CurrentPage = App.TestsPage;
        }

        private void GoToCalculator()
        {
            App.CalculatorViewPage = new Views.CalculatorView();
            App.ProfilViewModel.CurrentPage = App.CalculatorViewPage;
        }
    }
}
