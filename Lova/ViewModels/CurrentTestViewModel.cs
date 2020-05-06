using Models.Models;

namespace Presentation.ViewModels
{
    public class CurrentTestViewModel : ViewModelBase
    {
        private Test test;

        public CurrentTestViewModel()
        {

        }
        public CurrentTestViewModel(Test test)
        {
            this.test = test;
        }

        public Test Test 
        {
            get => test;
            set 
            {
                test = value;
                OnPropertyChanged("Test");
            }
        }

    }
}
