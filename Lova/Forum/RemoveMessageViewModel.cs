using Lova;
using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class RemoveMessageViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Message> messages;
        private Message selectedMessage;

        public ICommand RemoveMessageCommand => new RelayCommand(obj => RemoveMessage());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public RemoveMessageViewModel()
        {
            unitOfWork = new UnitOfWork();
            messages = new ObservableCollection<Message>(unitOfWork.MessageRepository.Get());
        }

        public ObservableCollection<Message> Messages
        {
            get => messages;
            set
            {
                messages = value;
                OnPropertyChanged("Messages");
            }
        }

        public Message SelectedMessage
        {
            get => selectedMessage;
            set
            {
                selectedMessage = value;
                OnPropertyChanged("SelectedDiscussion");
            }
        }

        private async void RemoveMessage()
        {
            if(selectedMessage != null)
            {
                await unitOfWork.MessageRepository.RemoveAsync(unitOfWork.MessageRepository.Get().FirstOrDefault(m => m.Text == selectedMessage.Text && m.When == selectedMessage.When).MessageId);

                MessageBox.Show("Сообщение удалено :)");

                App.RemoveMessagePage = new Views.RemoveMessageView();
                App.ProfilViewModel.CurrentPage = App.RemoveMessagePage;
            }
            else
            {
                MessageBox.Show("Упс... Вы не выбрали сообщение для удаления :)");
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

    }
}
