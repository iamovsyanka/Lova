using Lova;
using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using Models.Validation;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class AddQuestionsViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private string questionDescription;
        private string answer;
        private int countQuestios = 0;

        public ICommand AddQuestionCommand => new RelayCommand(obj => AddQuestion());
        public ICommand GoToTestCommand => new RelayCommand(obj => GoToTest());
               
        public AddQuestionsViewModel()
        {
            unitOfWork = new UnitOfWork();
        }

        public string QuestionDescription
        {
            get => questionDescription;
            set
            {
                questionDescription = value;
                OnPropertyChanged("QuestionDescription");
            }
        }

        public string Answer
        {
            get => answer;
            set
            {
                answer = value;
                OnPropertyChanged("Answer");
            }
        }

        private async void AddQuestion()
        {
            if (!string.IsNullOrEmpty(questionDescription) && !string.IsNullOrEmpty(answer) && Validation.regexText.IsMatch(questionDescription) && Validation.regexText.IsMatch(answer))
            {
                var newQuestion = new Question()
                {
                    TestId = CurrentTest.GetTestId(),
                    Description = questionDescription,
                    Answer = answer
                };

                await unitOfWork.QuestionRepository.AddAsync(newQuestion);
                countQuestios++;
                MessageBox.Show($"Вопрос добавлен, количество вопросов в тесте: {countQuestios}");

                QuestionDescription = null;
                Answer = null;
            }
            else
            {
                MessageBox.Show("Упс... Не все поля введены или начинаеются с пробела :(\nАккуратнее");
            }
        }

        private void GoToTest()
        {
            if(countQuestios != 0)
            {
                App.TestsPage = new Views.TestsView();
                App.ProfilViewModel.CurrentPage = App.TestsPage;
            }
            else
            {
                MessageBox.Show("Упс... Добавьте хотя бы один вопрос в тест :)");
            }
        }
    }
}
