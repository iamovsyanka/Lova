using Models.Commands;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class ForumViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Discussion> discussions;
        private ObservableCollection<DiscussionViewModel> messages;

        public ForumViewModel()
        {
            unitOfWork = new UnitOfWork();

            discussions = new ObservableCollection<Discussion>(unitOfWork.DiscussionRepository.Get());
            messages = new ObservableCollection<DiscussionViewModel>(unitOfWork.MessageRepository.Get().Select(m => new DiscussionViewModel(m)));
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

    }
}
