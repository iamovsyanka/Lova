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
        public static CurrentTestViewModel CurrentTestViewModel { get; set; } = new CurrentTestViewModel();
        public static UserTestViewModel UserTestViewModel { get; set; } = new UserTestViewModel();
        public static AddDiscussionViewModel AddDiscussionViewModel { get; set; } = new AddDiscussionViewModel();
        public static RemoveDiscussionViewModel RemoveDiscussionViewModel { get; set; } = new RemoveDiscussionViewModel();
        public static RemoveMessageViewModel RemoveMessageViewModel { get; set; } = new RemoveMessageViewModel();

        public static AddTestViewModel AddTestViewModel { get; set; } = new AddTestViewModel();
        public static AddQuestionsViewModel AddQuestionsViewModel { get; set; } = new AddQuestionsViewModel();
        public static CalculatorViewModel CalculatorViewModel { get; set; } = new CalculatorViewModel();
        public static LevensteinViewModel LevensteinViewModel { get; set; } = new LevensteinViewModel();

        public static ForumView ForumPage = new ForumView();
        public static TestsView TestsPage = new TestsView();
        public static CurrentTestView CurrentTestPage = new CurrentTestView();
        public static UserTestView UserTestPage = new UserTestView();
        public static AddDiscussionView AddDiscussionViewPage = new AddDiscussionView();
        public static RemoveDiscussionView RemoveDiscussionViewPage = new RemoveDiscussionView();
        public static RemoveMessageView RemoveMessageViewPage = new RemoveMessageView();
        public static AddTestView AddTestViewPage = new AddTestView();
        public static AddQuestionsView AddQuestionsViewPage = new AddQuestionsView();
        public static CalculatorView CalculatorViewPage = new CalculatorView();
        public static LevensteinView LevensteinViewPage = new LevensteinView();
    }
}
