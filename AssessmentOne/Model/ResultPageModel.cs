using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne.Model
{
    public class ResultPageModel
    {
        public string Result { get; set; }
        public int ResultPoint { get => 40; }
        public string PlayerName
        {
            get => "Kavan Patel";
        }
        public Image ImageShow { get; set; }

        public int TotalPoint 
        {
            get => 50;
        }

    }
}
