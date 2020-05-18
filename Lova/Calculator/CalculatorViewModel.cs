using Calculator;
using Lova;
using Models.Commands;
using System;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        private CalculatorModel calculator = new CalculatorModel();

        public string Display => calculator.Display;

        public CalculatorViewModel()
        {
            NumberCommand = new RelayCommand(param => { calculator.Number(Convert.ToInt32(param)); UpdateDisplay(); },
                                            param => calculator.CanDoNumber());

            PlusCommand = new RelayCommand(param => { calculator.Plus(); UpdateDisplay(); },
                                            param => calculator.CanDoSign());

            MinusCommand = new RelayCommand(param => { calculator.Minus(); UpdateDisplay(); },
                                            param => calculator.CanDoSign());

            TimesCommand = new RelayCommand(param => { calculator.Times(); UpdateDisplay(); },
                                            param => calculator.CanDoSign());

            OverCommand = new RelayCommand(param => { calculator.Over(); UpdateDisplay(); },
                                            param => calculator.CanDoSign());

            EqualsCommand = new RelayCommand(param => { calculator.Equals(); UpdateDisplay(); },
                                            param => calculator.CanDoEquals());

            ClearCommand = new RelayCommand(param => { calculator.Clear(); UpdateDisplay(); },
                                            param => calculator.CanDoClear());
        }

        public ICommand GoToLevensteinCommand => new RelayCommand(obj => GoToLevenstein());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());        
        
        public RelayCommand NumberCommand { get; private set; }
        public RelayCommand PlusCommand { get; private set; }
        public RelayCommand MinusCommand { get; private set; }
        public RelayCommand TimesCommand { get; private set; }
        public RelayCommand OverCommand { get; private set; }
        public RelayCommand EqualsCommand { get; private set; }
        public RelayCommand ClearCommand { get; private set; }

        private void GoToLevenstein()
        {
            App.LevensteinPage = new Views.LevensteinView();
            App.ProfilViewModel.CurrentPage = App.LevensteinPage;
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
        
        private void UpdateDisplay()
        {
            OnPropertyChanged("Display");
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
