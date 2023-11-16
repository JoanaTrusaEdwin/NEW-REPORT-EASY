namespace NEW_REPORT_EASY;

public partial class SubmitFeedback : ContentPage
{
	public SubmitFeedback()
	{
		InitializeComponent();
	}


    //DATABASE ALERT: PLS MODIFY THE CODE TO SUIT YOUR DATABASE IF NEEDED, THIS IS JUST EXAMPLE 
    private void OnSubmitFeedbackClicked(object sender, EventArgs e)
    {
        // Retrieve data from the form
        string name = NameEntry.Text;
        string email = EmailEntry.Text;
        string feedback = FeedbackEditor.Text;

        // Process and submit feedback (you can add your logic here)

        
        DisplayAlert("Feedback Submitted", "Thank you for your feedback!", "OK");
    }
}