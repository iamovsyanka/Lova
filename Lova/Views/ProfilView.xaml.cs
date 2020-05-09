using Lova;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Resources;

namespace Presentation.Views
{
    public partial class Profil : Window
    {
        public Profil()
        {
            InitializeComponent();

            StreamResourceInfo sri = Application.GetResourceStream(
                new Uri("Views/Resource/Cursor/cat.ani", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;

            DataContext = App.ProfilViewModel;
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }
    }
}
