using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());
        public ICommand GoToUserTestCommand => new RelayCommand(async obj => await GoToUserTest());
        public ICommand SearchTestCommand => new RelayCommand(obj => SearchTest());
        public ICommand AddTestCommand => new RelayCommand(async obj => await AddTest());

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

        public string Tooltip
        {
            get
            {
                var random = new Random();
                switch (random.Next(7))
                {
                    case 0:
                        return "Математика - это язык, на котором написана книга природы";
                    case 1:
                        return "Химия – правая рука физики, математика – ее глаз";
                    case 2:
                        return "Математика - это язык, на котором говорят все точные науки";
                    case 3:
                        return "Величие человека - в его способности мыслить";
                    case 4:
                        return "Математика есть лучшее и даже единственное введение в изучение природы";
                    case 5:
                        return "Полет – это математика";
                    default:
                        return "Математика — это единственный совершенный метод водить самого себя за нос";
                }
            }
        }

        private void GoToForum()
        {
            App.ForumPage = new Views.ForumView();
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }

        private void GoToTest()
        {
            if (selectedTest != null) 
            {
                CurrentTest.SetTestId(selectedTest.TestId);
                App.CurrentTestPage = new Views.CurrentTestView();
                App.ProfilViewModel.CurrentPage = App.CurrentTestPage;
            }
            else
            {
                MessageBox.Show("Упс... А вы не выбрали тест :)");
            }
        }

        private async Task GoToUserTest()
        {
            if (await unitOfWork.UserRepository.IsAdmin(CurrentUser.GetUserId()))
            {
                App.UsersTestPage= new Views.UsersTestView();
                App.ProfilViewModel.CurrentPage = App.UsersTestPage;
            }
            else
            {
                App.UserTestPage = new Views.UserTestView();
                App.ProfilViewModel.CurrentPage = App.UserTestPage;
            }
        }

        private void SearchTest()
        {
            if (!string.IsNullOrEmpty(testName)) 
            {
                var regex = new Regex(testName);
                var check = false;

                foreach (Test test in Tests)
                {
                    if (regex.IsMatch(test.Name))
                    {
                        check = true;

                        CurrentTest.SetTestId(test.TestId);
                        App.CurrentTestPage = new Views.CurrentTestView();
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

        private async Task AddTest()
        {
            if (await unitOfWork.UserRepository.IsAdmin(CurrentUser.GetUserId()))
            {
                App.AddTestPage = new Views.AddTestView();
                App.ProfilViewModel.CurrentPage = App.AddTestPage;
            }
            else
            {
                MessageBox.Show("Извините, эта функции доступна только для администратора");
            }
        }
    }
}
