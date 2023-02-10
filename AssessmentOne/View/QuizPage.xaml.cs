using AssessmentOne.ViewModel;
using AssessmentOne.ViewModel.QuestionAnswer;

namespace AssessmentOne.View;

public partial class QuizPage : ContentPage
{
    private QuizPageViewModel _quizPageViewModel;
    public QuizPage()
    {
        InitializeComponent();
        _quizPageViewModel = new QuizPageViewModel();

    }


    int C = 0;
    private async void Button_Clicked(object sender, EventArgs e)
    {
        C++;
        if (_quizPageViewModel.CurrentQuestion ==1 && OptionsOne.IsChecked == true)
        {
            OptionsOne.IsChecked = false;
            ValidateAnswer();
        }
       else if(_quizPageViewModel.CurrentQuestion == 1 && OptionsOne.IsChecked == false) 
        {
            Attempt();
        }
    }
    private void Option1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        One();
    }

    private void Option2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Two();
    }

    private void Option3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Three();
    }

    private void Option4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Four();
    }

    int Points = 0;
    private void ValidateAnswer()
    {
        C = 0;
        Points += 10;
        PointLabel.Text = Points.ToString();
    }



    private void One()
    {
        if(OptionsOne.IsChecked == true)
        {
            OptionsOne.BackgroundColor = Colors.CadetBlue;
            OptionsOne.TextColor = Colors.White;
            SubmitButton.IsEnabled = true;
        }
        else
        {
            OptionsOne.BackgroundColor = Colors.White;
            OptionsOne.TextColor = Colors.SeaGreen;
        }
    }

    private void Two()
    {
        if (OptionsTwo.IsChecked == true)
        {
            OptionsTwo.BackgroundColor = Colors.CadetBlue;
            OptionsTwo.TextColor = Colors.White;
            SubmitButton.IsEnabled = true;
        }
        else
        {
            OptionsTwo.BackgroundColor = Colors.White;
            OptionsTwo.TextColor = Colors.SeaGreen;
        }
    }

    private void Three()
    {
        if (OptionThree.IsChecked == true)
        {
            OptionThree.BackgroundColor = Colors.CadetBlue;
            OptionThree.TextColor = Colors.White;
            SubmitButton.IsEnabled = true;
        }
        else
        {
            OptionThree.BackgroundColor = Colors.White;
            OptionThree.TextColor = Colors.SeaGreen;
        }
    }

    private void Four()
    {
        if (OptionFour.IsChecked == true)
        {
            OptionFour.BackgroundColor = Colors.CadetBlue;
            OptionFour.TextColor = Colors.White;
            SubmitButton.IsEnabled = true;
        }
        else
        {
            OptionFour.BackgroundColor = Colors.White;
            OptionFour.TextColor = Colors.SeaGreen;
        }
    }

    private async void Attempt()
    {
        if (C == 1)
        {
            ErrorLabel.Text = "You Have 2 attemps left";
            Points -= 5;
            PointLabel.Text= Points.ToString();
        }else if (C == 2)
        {
            ErrorLabel.Text = "You have last attemp left";
            Points -= 5;
            PointLabel.Text = Points.ToString();
        }else
        {
            await Navigation.PushAsync(new ResultPage());
        }

    }


}
