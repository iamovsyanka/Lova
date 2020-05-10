using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class CurrentTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Question> questions;
        private Question selectedQuestion;
        private string answer;
        private int countCorrectAnswers = 0;

        public ICommand SaveAnswerCommand => new RelayCommand(obj => AddAnswer());
        public ICommand CheckTestCommand => new RelayCommand(obj => CheckTest());
        public ICommand GoToForumCommand => new RelayCommand(obj => GoToForum());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());

        public CurrentTestViewModel()
        {
            unitOfWork = new UnitOfWork();

            questions = new ObservableCollection<Question>(unitOfWork.QuestionRepository.GetQuestionsByTestId(CurrentTest.GetTestId()));
        }

        public ObservableCollection<Question> Questions
        {
            get => questions;
            set
            {
                questions = value;
                OnPropertyChanged("Questions");
            }
        }

        public Question SelectedQuestion
        {
            get => selectedQuestion;
            set
            {
                selectedQuestion = value;
                OnPropertyChanged("SelectedQuestions");
            }
        }

        public string TestName => unitOfWork.TestRepository.GetTestNameById(CurrentTest.GetTestId());

        public string Answer
        {
            get => answer;
            set
            {
                answer = value;
                OnPropertyChanged("Answer");
            }
        }

        private void AddAnswer()
        {
            if(selectedQuestion != null)
            {
                if(answer != null)
                {
                    if(selectedQuestion.Answer == answer)
                    {
                        countCorrectAnswers++;
                    }
                    Answer = null;
                }
                else
                {
                    MessageBox.Show("Упс... Ответа нет, а он должен быть :)");

                }
            }
            else
            {
                MessageBox.Show("Упс... А вы не выбрали вопрос для ответа :)");
            }

        }

        private async void CheckTest()
        {
            var newUserTest = new UserTest()
            {
                TestName = unitOfWork.TestRepository.GetTestNameById(CurrentTest.GetTestId()),
                UserId = CurrentUser.GetUserId(),
                TestId = CurrentTest.GetTestId(),
                Result = $"{countCorrectAnswers} / {questions.Count}",
                SolvedTime = DateTime.Now
            };

            await unitOfWork.UserTestRepository.AddAsync(newUserTest);

            App.UserTestPage= new Views.UserTestView();
            App.ProfilViewModel.CurrentPage = App.UserTestPage;           
        }

        private void GoToForum()
        {
            App.ForumPage = new Views.ForumView();
            App.ProfilViewModel.CurrentPage = App.ForumPage;
        }

        private void GoToTest()
        {
            App.TestsPage = new Views.TestsView();
            App.ProfilViewModel.CurrentPage = App.TestsPage;
        }
    }
}
