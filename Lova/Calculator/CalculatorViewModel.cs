using Lova;
using Models.Commands;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class CalculatorViewModel : ViewModelBase
    {
        public ICommand GoToLevensteinCommand => new RelayCommand(obj => GoToLevenstein());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        private void GoToLevenstein()
        {
            App.LevensteinViewPage = new Views.LevensteinView();
            App.ProfilViewModel.CurrentPage = App.LevensteinViewPage;
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
