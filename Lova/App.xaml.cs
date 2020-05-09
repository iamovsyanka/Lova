﻿using Presentation.ViewModels;
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
        public static AddDiscussionViewModel AdminViewModel { get; set; } = new AddDiscussionViewModel();

        public static ForumView ForumPage = new ForumView();
        public static TestsView TestsPage = new TestsView();
        public static CurrentTestView CurrentTestPage = new CurrentTestView();
        public static UserTestView UserTestPage = new UserTestView();
        public static AddDiscussionView AdminViewPage = new AddDiscussionView();
    }
}
