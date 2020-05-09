using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Resources;

namespace Presentation.Views
{
    public partial class RegistrationView : Window
    {
        public RegistrationView()
        {            
            InitializeComponent();

            StreamResourceInfo sri = Application.GetResourceStream(
                new Uri("Views/Resource/Cursor/cat.ani", UriKind.Relative));
            var customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;
        }

        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
                if (DataContext != null)
                { ((dynamic)DataContext).Password = ((PasswordBox)sender).Password; }
        }

        private void confirmedPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext != null)
                if (DataContext != null)
                { ((dynamic)DataContext).ConfirmedPassword = ((PasswordBox)sender).Password; }
        }
    }
}
