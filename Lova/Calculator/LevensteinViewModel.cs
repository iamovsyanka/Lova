using Calculator;
using Lova;
using Models.Commands;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class LevensteinViewModel : ViewModelBase
    {
        private string firstString = "";
        private string secondString = "";
        private string result;

        public ICommand LevensteinCommand => new RelayCommand(obj => GetLevenstein());
        public ICommand GoToCalculatorCommand => new RelayCommand(obj => GoToCalculator());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public string FirstString
        {
            get => firstString;
            set
            {
                firstString = value;
                OnPropertyChanged("FirstString");
            }
        }

        public string SecondString
        {
            get => secondString;
            set
            {
                secondString = value;
                OnPropertyChanged("SecondString");
            }
        }

        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        private void GetLevenstein()
        {
            var distance = Levenstein.LevensteinDynamic(firstString, secondString);
            Result = $"Дистанция Левенштейна между {firstString} и {secondString} составляет {distance}";
        }

        private void GoToCalculator()
        {
            App.CalculatorPage = new Views.CalculatorView();
            App.ProfilViewModel.CurrentPage = App.CalculatorPage;
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
    }
}
