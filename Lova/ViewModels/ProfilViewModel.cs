using System.Windows.Controls;

namespace Presentation.ViewModels
{
    public class ProfilViewModel : ViewModelBase
    {
        private Page currentPage;

        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                if (currentPage == value)
                {
                    return;
                }

                currentPage = value;
                OnPropertyChanged();
            }
        }
    }
}
