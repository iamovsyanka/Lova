using Lova;
using Models.Models;
using Presentation.ViewModels;
using System.Windows.Controls;

namespace Presentation.Views
{
    public partial class CurrentTest : Page
    {
        public CurrentTest(Test test)
        {
            InitializeComponent();

            CurrentTestViewModel currentTestViewModel = new CurrentTestViewModel(test);
            DataContext = currentTestViewModel;
        }
    }
}
