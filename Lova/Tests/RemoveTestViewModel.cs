using Lova;
using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class RemoveTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Test> tests;
        private Test selectedTest;

        public ICommand RemoveTestCommand => new RelayCommand(obj => RemoveTest());
        public ICommand AddTestCommand => new RelayCommand(obj => GoToAddTest());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public RemoveTestViewModel()
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

        private async void RemoveTest()
        {
            if(selectedTest != null)
            {
                await unitOfWork.TestRepository.RemoveByNameAsync(selectedTest.Name);

                MessageBox.Show("Тест удалён :)");

                App.RemoveTestPage = new Views.RemoveTestView();
                App.ProfilViewModel.CurrentPage = App.RemoveTestPage;
            }
            else
            {
                MessageBox.Show("Упс... Вы не ввели данные для удаления :)");
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

        private void GoToAddTest()
        {
            App.AddTestPage = new Views.AddTestView();
            App.ProfilViewModel.CurrentPage = App.AddTestPage;
        }
    }
}
