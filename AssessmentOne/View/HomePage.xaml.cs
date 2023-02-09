using AssessmentOne.Model;
using CommunityToolkit.Maui.Alerts;
namespace AssessmentOne.View;


public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void SubmitButton_Clicked(object sender, EventArgs e)
    {

        HomePageModel homePageModel = new HomePageModel()
        {
            PlayerName = NameEntry.Text,
        };

        if (string.IsNullOrEmpty(NameEntry.Text))
        {
            Toast.Make("Please Enter Name", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
        }
        else
        {
            await Navigation.PushAsync(new WelcomePage(homePageModel));
        }
    }
}