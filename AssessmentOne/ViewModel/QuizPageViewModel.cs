using AssessmentOne.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AssessmentOne.ViewModel.QuestionAnswer
{
    public class QuizPageViewModel : INotifyPropertyChanged
    {
        private QuizPageModel _quizPageModel;

        public ICommand SubmitCommand { get; private set; }

        public int TotalQuestion => _quizPageModel.TotalQuestion;

        private int _currentQuestion;

        public int CurrentQuestion
        {
            get { return Counts+1; }           
        }
        public string Que
        {
            get
            {
                if (Counts == 0)
                {
                    return _quizPageModel.ListOfQuestion[0];
                }
                else
                    return Question;
            }
        }

        private string _question;
        public string Question
        {
            get { return _question; }
            set
            {              
                _question = value;
                OnPropertyChanged();
            }
        }

        private int _counts;

        public int Counts
        {
            get { return _counts; }
            set
            {
                _counts = value;
                OnPropertyChanged();
            }
        }

        public string Option1
        {
            get
            {
                if (Counts == 0)
                {
                    return _quizPageModel.OptionOne[0];
                }
                else
                    return MCQ1;
            }
        }

        private string _mcq1;
        public string MCQ1
        {
            get { return _mcq1; }
            set
            {
                _mcq1 = value;
                OnPropertyChanged();
            }
        }


        public string Option2
        {
            get
            {
                if (Counts == 0)
                {
                    return _quizPageModel.OptionOne[1];
                }
                else
                    return MCQ2;
            }
        }

        private string _mcq2;

        public string MCQ2
        {
            get { return _mcq2; }
            set
            {
                _mcq2 = value;
                OnPropertyChanged();
            }
        }

        public string Option3
        {
            get
            {
                if (Counts == 0)
                {
                    return _quizPageModel.OptionOne[2];
                }
                else
                    return MCQ3;
            }
        }

        private string _mcq3;

        public string MCQ3
        {
            get { return _mcq3; }
            set
            {
                _mcq3 = value;
                OnPropertyChanged();
            }
        }


        public string Option4
        {
            get
            {
                if (Counts == 0)
                {
                    return _quizPageModel.OptionOne[3];
                }
                else
                    return MCQ4;
            }
        }
        private string _mcq4;

        public string MCQ4
        {
            get { return _mcq4; }
            set
            {
                _mcq4 = value;
                OnPropertyChanged();
            }
        }

        private string _answerOfQuestion;
 
        public string AnswerOfQuestion
        {
            get { return _answerOfQuestion; }
            set { _answerOfQuestion= value;
            OnPropertyChanged();}
        }

       
      
        private bool _check1;
        public bool Check1
        {
            get
            {
                return _check1;
            }
            set
            {
                if (_check1 != value)
                {
                    _check1 = value;
                    OnPropertyChanged();
                }
            }
        }



        private bool _check2;
        public bool Check2
        {
            get
            {
                return _check2;
            }
            set
            {
                if (_check2 != value)
                {
                    _check2 = value;
                    OnPropertyChanged();
                }
            }
        }



        private bool _check3;
        public bool Check3
        {
            get
            {
                return _check3;
            }
            set
            {
                if (_check3 != value)
                {
                    _check3 = value;
                    OnPropertyChanged();
                }
            }
        }



        private bool _check4;
        public bool Check4
        {
            get
            {
                return _check4;
            }
            set
            {
                if (_check4 != value)
                {
                    _check4 = value;
                    OnPropertyChanged();
                }
            }
        }



       

       
        public double Progress
        {
            get { return CurrentQuestion * 0.167; }
        }

        public QuizPageViewModel()
        {
            _quizPageModel = new QuizPageModel();            
            SubmitCommand = new Command(Display);
        }
      

        public void Display()
        {
            ClearCheck();
            DisplayQuestion();           
        }
      public void ClearCheck()
        {
            Check1= false;
            Check2= false;
            Check3= false;
            Check4= false;
        }
        public void DisplayQuestion()
        {         
            Counts++;
            if(Counts > _quizPageModel.ListOfQuestion.Count)
            {
                Counts = 0;
            }
            else
            {
                 Question = _quizPageModel.ListOfQuestion[Counts];
            }
           
            
            if (Counts == 1)
            {
                MCQ1 = _quizPageModel.OptionTwo[0];
                MCQ2 = _quizPageModel.OptionTwo[1];
                MCQ3 = _quizPageModel.OptionTwo[2];
                MCQ4 = _quizPageModel.OptionTwo[3];
                AnswerOfQuestion = _quizPageModel.OptionTwo[4];
            }
            else if (Counts == 2)
            {
                MCQ1 = _quizPageModel.OptionThree[0];
                MCQ2 = _quizPageModel.OptionThree[1];
                MCQ3 = _quizPageModel.OptionThree[2];
                MCQ4 = _quizPageModel.OptionThree[3];
            }
            else if (Counts == 3)
            {
                MCQ1 = _quizPageModel.OptionFour[0];
                MCQ2 = _quizPageModel.OptionFour[1];
                MCQ3 = _quizPageModel.OptionFour[2];
                MCQ4 = _quizPageModel.OptionFour[3];
            }
            else if (Counts == 4)
            {
                MCQ1 = _quizPageModel.OptionFive[0];
                MCQ2 = _quizPageModel.OptionFive[1];
                MCQ3 = _quizPageModel.OptionFive[2];
                MCQ4 = _quizPageModel.OptionFive[3];
            }
            else if (Counts == 5)
            {
                MCQ1 = _quizPageModel.OptionSix[0];
                MCQ2 = _quizPageModel.OptionSix[1];
                MCQ3 = _quizPageModel.OptionSix[2];
                MCQ4 = _quizPageModel.OptionSix[3];

            }

        }


       
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name = "")
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
