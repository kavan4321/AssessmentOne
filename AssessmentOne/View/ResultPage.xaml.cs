namespace AssessmentOne.View;

public partial class ResultPage : ContentPage
{
	public ResultPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }
}