using Lova;
using Models.Commands;
using Models.UnitOfWork;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class RemoveDiscussionViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string discussionName;

        public ICommand RemoveDiscussionCommand => new RelayCommand(obj => RemoveDiscussion());
        public ICommand AddDiscussionCommand => new RelayCommand(obj => GoToAddDiscussion());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public RemoveDiscussionViewModel()
        {
            unitOfWork = new UnitOfWork();
        }

        public string DiscussionName
        {
            get => discussionName;
            set
            {
                discussionName = value;
                OnPropertyChanged("DiscussionName");
            }
        }

        private async void RemoveDiscussion()
        {
            if(discussionName != null)
            {
                await unitOfWork.DiscussionRepository.RemoveByNameAsync(discussionName);

                DiscussionName = null;
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

        private void GoToAddDiscussion()
        {
            App.AddDiscussionViewPage = new Views.AddDiscussionView();
            App.ProfilViewModel.CurrentPage = App.AddDiscussionViewPage;
        }
    }
}
