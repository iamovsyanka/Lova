using Calculator;
using Presentation.ViewModels;
using Presentation.Views;
using System.Windows;

namespace Lova
{
    public partial class App : Application
    {
        public static ProfilViewModel ProfilViewModel { get; set; } = new ProfilViewModel();
        public static LoginViewModel LoginViewModel { get; set; } = new LoginViewModel();
        public static RegistrationViewModel RegistrationViewModel { get; set; } = new RegistrationViewModel();
        public static TestsViewModel TestsViewModel { get; set; } = new TestsViewModel();
        public static ForumViewModel ForumViewModel { get; set; } = new ForumViewModel();
        public static CurrentTestViewModel CurrentTestViewModel { get; set; } = new CurrentTestViewModel();
        public static UserTestViewModel UserTestViewModel { get; set; } = new UserTestViewModel();
        public static UsersTestViewModel UsersTestViewModel { get; set; } = new UsersTestViewModel();
        public static AddDiscussionViewModel AddDiscussionViewModel { get; set; } = new AddDiscussionViewModel();
        public static RemoveTestViewModel RemoveDiscussionViewModel { get; set; } = new RemoveTestViewModel();
        public static RemoveMessageViewModel RemoveMessageViewModel { get; set; } = new RemoveMessageViewModel();
        public static RemoveTestViewModel RemoveTestViewModel { get; set; } = new RemoveTestViewModel();
        public static AddTestViewModel AddTestViewModel { get; set; } = new AddTestViewModel();
        public static AddQuestionsViewModel AddQuestionsViewModel { get; set; } = new AddQuestionsViewModel();
        public static CalculatorViewModel CalculatorViewModel { get; set; } = new CalculatorViewModel();
        public static LevensteinViewModel LevensteinViewModel { get; set; } = new LevensteinViewModel();

        public static LoginView LoginPage = new LoginView();
        public static RegistrationView RegistrationPage = new RegistrationView();
        public static ForumView ForumPage = new ForumView();
        public static TestsView TestsPage = new TestsView();
        public static CurrentTestView CurrentTestPage = new CurrentTestView();
        public static UserTestView UserTestPage = new UserTestView();
        public static UsersTestView UsersTestPage = new UsersTestView();
        public static AddDiscussionView AddDiscussionPage = new AddDiscussionView();
        public static RemoveDiscussionView RemoveDiscussionPage = new RemoveDiscussionView();
        public static RemoveMessageView RemoveMessagePage = new RemoveMessageView();
        public static RemoveTestView RemoveTestPage = new RemoveTestView();
        public static AddTestView AddTestPage = new AddTestView();
        public static AddQuestionsView AddQuestionsPage = new AddQuestionsView();
        public static CalculatorView CalculatorPage = new CalculatorView();
        public static LevensteinView LevensteinPage = new LevensteinView();
    }
}
