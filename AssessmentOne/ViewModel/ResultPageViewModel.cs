using AssessmentOne.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AssessmentOne.ViewModel.ResultPageShow
{
    public class ResultPageViewModel : INotifyPropertyChanged
    {
        private ResultPageModel _resultPageModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ReplayCommand { get; private set; }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int _resultPoint;
        public int ResultPoint
        {
            get { return _resultPoint; }
            set {
                _resultPoint = value;
                OnPropertyChanged();
            }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }


        private Image _imageShow;

        public Image ImageShow
        {
            get { return _imageShow; }
            set {
                _imageShow = value;
                OnPropertyChanged(); }
        }

        private string _playerName;

        public string PlayerName
        { 
            get { return _playerName; }
            set { _playerName = value;
                OnPropertyChanged(); 
            }
        }


        private int _totalPoint;

        public int TotalPoint
        {
            get { return _totalPoint; }
            set
            {
                _totalPoint = value;
                OnPropertyChanged();
            }
        }

        public void ShowResultScreen()
        {

            int Percentage = (ResultPoint/ TotalPoint) * 100;
            if (Percentage == 100)
            {
                ImageShow.Source = "gold";
            }else if(Percentage >= 76 && Percentage <= 99)
            {
                ImageShow.Source = "silver";
            }else if(Percentage >=51 && Percentage <= 75)
            {
                ImageShow.Source = "bronze";
            }
            
        }

        public ResultPageViewModel()
        {
            _resultPageModel = new ResultPageModel();
            PlayerName = _resultPageModel.PlayerName;
            TotalPoint = _resultPageModel.TotalPoint;
            ReplayCommand = new Command(ShowResultScreen);
        }

    }

}
