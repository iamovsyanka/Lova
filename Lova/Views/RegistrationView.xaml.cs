using System.Windows;
using System.Windows.Controls;

namespace Presentation.Views
{
    public partial class Registration : Window
    {
        public Registration()
        {            
            InitializeComponent();
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
