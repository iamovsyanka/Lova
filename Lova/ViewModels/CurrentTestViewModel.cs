using Models.Current;
using Models.Models;
using Models.UnitOfWork;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Presentation.ViewModels
{
    public class CurrentTestViewModel : ViewModelBase
    {
        private readonly UnitOfWork unitOfWork;
        private ObservableCollection<Variant> variants;
        private ObservableCollection<Question> questions;

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
    }
}
