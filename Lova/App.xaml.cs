using Presentation.ViewModels;
using Presentation.Views;
using System.Windows;

namespace Lova
{
    public partial class App : Application
    {
        public static ProfilViewModel ProfilViewModel { get; set; } = new ProfilViewModel();
        public static TestsViewModel TestsViewModel { get; set; } = new TestsViewModel();
        public static ForumViewModel ForumViewModel { get; set; } = new ForumViewModel();

        public static Forum ForumPage = new Forum();
        public static Tests TestsPage = new Tests();
    }
}
