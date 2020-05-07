using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class TestsViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Test> tests;
        private Test selectedTest;
        private string testName;

        public ICommand GoToForumCommand => new RelayCommand(obj => CanGoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => CanGoToTest());
        public ICommand SearchTestCommand => new RelayCommand(obj => SearchTest());

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

        public string TestName
        {
            get => testName;
            set
            {
                testName = value;
                OnPropertyChanged("TestName");
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

        private void SearchTest()
        {
            if (testName != null) 
            {
                var regex = new Regex(testName);
                var check = false;

                foreach (Test test in Tests)
                {
                    if (regex.IsMatch(test.Name))
                    {
                        check = true;

                        CurrentTest.SetTestId(test.TestId);
                        App.CurrentTestPage = new Views.CurrentTest();
                        App.ProfilViewModel.CurrentPage = App.CurrentTestPage;
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Упс... А такого теста нет :(");
                }
            }
            else
            {
                MessageBox.Show("Упс... Вы ничего не ввели :(");
            }
        }
    }
}
