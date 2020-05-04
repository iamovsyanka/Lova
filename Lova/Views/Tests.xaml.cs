using Lova;
using System.Windows.Controls;

namespace Presentation.Views
{
    public partial class Tests : Page
    {
        public Tests()
        {
            InitializeComponent();
            DataContext = App.TestsViewModel;
        }
    }
}
