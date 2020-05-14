using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class AddTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string testName;
        private string testDescription;
        private string testCategory;

        public ICommand AddTestCommand => new RelayCommand(obj => AddTest());
        public ICommand RemoveTestCommand => new RelayCommand(obj => RemoveTest());

        public AddTestViewModel()
        {
            unitOfWork = new UnitOfWork();
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

        public string TestDescription
        {
            get => testDescription;
            set
            {
                testDescription = value;
                OnPropertyChanged("TestDescription");
            }
        }

        public string TestCategory
        {
            get => testCategory;
            set
            {
                testCategory = value;
                OnPropertyChanged("TestCategory");
            }
        }

        private async void AddTest()
        {
            if(testName != null && testDescription != null && testCategory != null)
            {
                var newTest = new Test()
                {
                    Name = testName,
                    Description = testDescription,
                    Category = testCategory
                };

                await unitOfWork.TestRepository.AddAsync(newTest);

                CurrentTest.SetTestId(unitOfWork.TestRepository.Get().FirstOrDefault(t => t.Name == testName).TestId);

                App.AddQuestionsViewPage = new Views.AddQuestionsView();
                App.ProfilViewModel.CurrentPage = App.AddQuestionsViewPage;
            }
            else
            {
                MessageBox.Show("Упс... Не все поля введены :(");
            }
        }

        private void RemoveTest()
        {
            App.RemoveTestViewPage = new Views.RemoveTestView();
            App.ProfilViewModel.CurrentPage = App.RemoveTestViewPage;
        }
    }
}
