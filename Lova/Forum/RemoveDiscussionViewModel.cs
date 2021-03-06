﻿using Lova;
using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class RemoveDiscussionViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Discussion> discussions;
        private Discussion selectedDiscussion;

        public ICommand RemoveDiscussionCommand => new RelayCommand(obj => RemoveDiscussion());
        public ICommand AddDiscussionCommand => new RelayCommand(obj => GoToAddDiscussion());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public RemoveDiscussionViewModel()
        {
            unitOfWork = new UnitOfWork();
            discussions = new ObservableCollection<Discussion>(unitOfWork.DiscussionRepository.Get());
        }  

        public ObservableCollection<Discussion> Discussions
        {
            get => discussions;
            set
            {
                discussions = value;
                OnPropertyChanged("Discussions");
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

        private async void RemoveDiscussion()
        {
            if(selectedDiscussion != null)
            {
                await unitOfWork.DiscussionRepository.RemoveByNameAsync(selectedDiscussion.DiscussionName);

                MessageBox.Show("Обсуждение удалено :)");

                App.RemoveDiscussionPage = new Views.RemoveDiscussionView();
                App.ProfilViewModel.CurrentPage = App.RemoveDiscussionPage;
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
            App.AddDiscussionPage = new Views.AddDiscussionView();
            App.ProfilViewModel.CurrentPage = App.AddDiscussionPage;
        }
    }
}
