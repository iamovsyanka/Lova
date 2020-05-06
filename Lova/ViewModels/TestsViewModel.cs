using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class TestsViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Test> tests;
        private Test selectedTest;
        public ICommand GoToForumCommand => new RelayCommand(obj => CanGoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => CanGoToTest());


        public TestsViewModel()
        {
            unitOfWork = new UnitOfWork();

            tests = new ObservableCollection<Test>(unitOfWork.TestRepository.Get());
        }

        public ObservableCollection<Test> Tests
        {
            get => tests;
            set
            {
                tests = value;
                OnPropertyChanged("Tests");
            }
        }

        public Test SelectedTest 
        {
            get => selectedTest;
            set
            {
                selectedTest = value;
                OnPropertyChanged("SelectedTest");
            }
        }

        private void CanGoToForum()
        {
            App.ForumPage = new Views.Forum();
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }

        private void CanGoToTest()
        {         
            CurrentTest.SetTestId(selectedTest.TestId); 
            App.CurrentTestPage = new Views.CurrentTest();
            App.ProfilViewModel.CurrentPage = App.CurrentTestPage;
        }
    }
}
