using AssessmentOne.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne.ViewModel.Welcome;

public class WelcomePageViewModel : INotifyPropertyChanged 
{

    private HomePageModel _homePageName;

    public HomePageModel homePageName
    {
        get { return _homePageName; }
        set
        {
            _homePageName = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
