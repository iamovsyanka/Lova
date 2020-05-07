using Models.Commands;
using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class CurrentTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Variant> variants;
        private ObservableCollection<Question> questions;
        private Question selectedQuestion;
        private bool isTrue;
        public ICommand CheckTestCommand => new RelayCommand(obj => CheckTest());


        public CurrentTestViewModel()
        {
            unitOfWork = new UnitOfWork();

            questions = new ObservableCollection<Question> ( unitOfWork.QuestionRepository.GetQuestionsByTestId(CurrentTest.GetTestId()) );
            variants = new ObservableCollection<Variant>(unitOfWork.VariantRepository.Get());
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

        public ObservableCollection<Variant> Variants
        {
            get => variants;
            set
            {
                variants = value;
                OnPropertyChanged("Variants");
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

        public bool IsSelected
        {
            get => isTrue;
            set
            {
                isTrue = value;
                OnPropertyChanged("IsTrue");
            }
        }


        private void CheckTest()
        {
            var countQuestions = questions.Count;

            foreach(Question question in questions)
            {
                foreach(Variant variant in question.Variants)
                {
                    if(variant.IsTrue == IsSelected)
                    {
                        MessageBox.Show(variant.Description);
                    }
                }
            }
        }
    }
}
