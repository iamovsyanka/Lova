using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class DiscussionViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private Discussion discussion;
        private Message message;

        public DiscussionViewModel(Message message)
        {
            unitOfWork = new UnitOfWork();

            this.message = message;
        }

        public Discussion Discussion
        {
            get => discussion;
            set
            {
                discussion = value;
                OnPropertyChanged("Discussion");
            }
        }

        public Message Message
        {
            get => message;
            set
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }


        public ICommand SendMessageCommand => new RelayCommand(obj => CanSendMessage());

        private async void CanSendMessage()
        {
            MessageBox.Show("dbvjsbvh");
            await unitOfWork.MessageRepository.AddAsync(new Message() { });
        }
    }

}
