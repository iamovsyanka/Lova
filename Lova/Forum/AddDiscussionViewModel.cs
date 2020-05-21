using Lova;
using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class AddDiscussionViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string discussionName;
        private string discussionText;

        public ICommand AddDiscussionCommand => new RelayCommand(obj => AddDiscussion());
        public ICommand RemoveDiscussionCommand => new RelayCommand(obj => GoToRemoveDiscussion());
        public ICommand RemoveMessageCommand => new RelayCommand(obj => GoToRemoveMessage());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public AddDiscussionViewModel()
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

        public string DiscussionText
        {
            get => discussionText;
            set
            {
                discussionText = value;
                OnPropertyChanged("DiscussionText");
            }
        }

        private async void AddDiscussion()
        {
            if (string.IsNullOrEmpty(discussionName) || string.IsNullOrEmpty(discussionText))
            {
                MessageBox.Show("Упс... Не все поля введены :(");
            }
            else
            {
                var newDiscussion = new Discussion()
                {
                    DiscussionName = discussionName,
                    Text = discussionText
                };

                await unitOfWork.DiscussionRepository.AddAsync(newDiscussion);
                MessageBox.Show("Обсуждение добавлено :)");

                DiscussionName = null;
                DiscussionText = null;
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

        private void GoToRemoveDiscussion()
        {
            App.RemoveDiscussionPage = new Views.RemoveDiscussionView();
            App.ProfilViewModel.CurrentPage = App.RemoveDiscussionPage;
        }

        private void GoToRemoveMessage()
        {
            App.RemoveMessagePage = new Views.RemoveMessageView();
            App.ProfilViewModel.CurrentPage = App.RemoveMessagePage;
        }
    }
}
