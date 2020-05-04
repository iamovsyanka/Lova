using Lova;
using System.Windows.Controls;

namespace Presentation.Views
{
    public partial class Forum : Page
    {
        public Forum()
        {
            InitializeComponent();
            DataContext = App.ForumViewModel;
        }
    }
}
