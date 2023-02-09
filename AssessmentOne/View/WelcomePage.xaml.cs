using AssessmentOne.Model;
using AssessmentOne.ViewModel;
using AssessmentOne.ViewModel.Welcome;
using CommunityToolkit.Maui.Alerts;

namespace AssessmentOne.View;

public partial class WelcomePage : ContentPage
{
    private WelcomePageViewModel _welcomePageViewModel;
    public WelcomePage(HomePageModel homePageModel)
    {
        InitializeComponent();
        _welcomePageViewModel = (WelcomePageViewModel)BindingContext;
        _welcomePageViewModel.homePageName = homePageModel;
    }

    private async void StartButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuizPage());
    }
}

