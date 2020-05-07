using Presentation.ViewModels;
using System.Windows.Controls;

namespace Presentation.Views
{
    public partial class CurrentTest : Page
    {
        public CurrentTest()
        {
            InitializeComponent();

            CurrentTestViewModel currentTestViewModel = new CurrentTestViewModel();
            DataContext = currentTestViewModel;
        }

    }
}
