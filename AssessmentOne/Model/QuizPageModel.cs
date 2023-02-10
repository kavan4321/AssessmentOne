using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne.Model
{
    public class QuizPageModel
    {
        public string Question { get; set; }
        public int TotalQuestion
        {
            get
            {
                return ListOfQuestion.Count;
            }
        }
        public int IndexOfQuestion { get; set; }

        public List<string> ListOfQuestion = new(new string[]
             {
                "What is the capital of india?",
                "Which of the following is used in pencils?",
                "Chemical formula for water is?",
                "Washing soda is the common name for",
                "Gujarat comes under which railway zone of india?",
                "In which district of Gujarat sunrise occurs first?"
            });
        public List<string> OptionOne = new(new string[]
            {"Delhi","Mumbai","Kolkata","Chennai","Delhi"});

        public List<string> OptionTwo = new(new string[]
            {"Graphite","Silicon","Charcoal","Phosphorous","Graphite"});

        public List<string> OptionThree = new(new string[]
            {"NaA1O2","H2O","Al2O3","CaSiO3","H2O"});

        public List<string> OptionFour = new(new string[]
            {"Sodium Carbonate","Calcium Bicarbonate","Calcium Carbonate","Carbonate","Sodium Carbonate"});

        public List<string> OptionFive = new(new string[]
           {"South Railway","Northern Railway","Eastern Railway","Western Railway","Western Railway"});

        public List<string> OptionSix = new(new string[]
           {"Delhi","Mumbai","Kolkata","Chennai"});



    }
}