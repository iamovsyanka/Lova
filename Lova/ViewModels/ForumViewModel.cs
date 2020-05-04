using Lova;
using Models.Commands;
using Models.CurrentUser;
using Models.Models;
using Models.UnitOfWork;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class ForumViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Discussion> discussions;
        private ObservableCollection<Message> messages;
        private Discussion selectedDiscussion;
        private Message selectedMessage;
        private string messageText;

        public ICommand SendMessageCommand => new RelayCommand(obj => CanSendMessage());
        public ICommand GoToTestCommand => new RelayCommand(obj => CanGoToTest());


        public ForumViewModel()
        {
            unitOfWork = new UnitOfWork();

            discussions = new ObservableCollection<Discussion>(unitOfWork.DiscussionRepository.Get());
            messages = new ObservableCollection<Message>(unitOfWork.MessageRepository.Get());
        }

        //private Task Refresh()
        //{
        //    while (true)
        //    {
        //        App.ForumPage = new Views.Forum();
        //        App.ProfilViewModel.CurrentPage = App.ForumPage;
        //        Thread.Sleep(5000);
        //    }
        //}

        public ObservableCollection<Discussion> Discussions 
        {
            get => discussions;
            set
            {
                discussions = value;
                OnPropertyChanged("Discussions");
            }
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

        public Discussion SelectedDiscussion
        {
            get => selectedDiscussion;
            set
            {
                selectedDiscussion = value;
                OnPropertyChanged("SelectedDiscussion");
            }
        }

        public Message SelectedMessage
        {
            get => selectedMessage;
            set
            {
                selectedMessage = value;
                OnPropertyChanged("SelectedMessage");
            }
        }

        public string MessageText
        {
            get => messageText;
            set
            {
                if(value != null)
                {
                    messageText = value;
                }

                OnPropertyChanged("MessageText");
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

        private async void CanSendMessage()
        {
            try {
                var message = new Message()
                {
                    DiscussionId = selectedDiscussion.DiscussionId,
                    Text = messageText,
                    UserId = CurrentUser.GetUserId(),
                    UserName = unitOfWork.UserRepository.GetUserNameById(CurrentUser.GetUserId()),
                    When = DateTime.Now
                };
                await unitOfWork.MessageRepository.AddAsync(message);

                App.ForumPage = new Views.Forum();
                App.ProfilViewModel.CurrentPage = App.ForumPage;
            }
            catch {
                MessageBox.Show("Упс... А вы не выбрали обсуждение для отправки сообщения :)");
            }

        }

        private void CanGoToTest()
        {
            App.TestsPage = new Views.Tests();
            App.ProfilViewModel.CurrentPage = App.TestsPage;
        }

        //private async void CanDeleteMessage()
        //{
        //    try {
        //        if (selectedMessage.UserId == CurrentUser.GetUserId())
        //        {
        //            await unitOfWork.MessageRepository.RemoveAsync(selectedMessage.MessageId);
        //        }

        //        App.ForumPage = new Views.Forum();
        //        App.ProfilViewModel.CurrentPage = App.ForumPage;
        //    }
        //    catch {
        //        MessageBox.Show("Упс... А вы не выбрали сообщение для удаления");
        //    }
        //}
    }
}
