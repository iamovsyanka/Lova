using Lova;
using System.Windows;

namespace Presentation.Views
{
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();
            DataContext = App.ProfilViewModel;
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }
    }
}
