namespace NEW_REPORT_EASY.ADMIN;

public partial class ADMINMenu : ContentPage
{
	public ADMINMenu()
	{
		InitializeComponent();
    }

    private async void OnMyProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ADMINMyProfile());
    }

    private async void OnReportsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ADMINReportReview());
    }

    private async void OnReviewedReportsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReviewedReports());
    }

    private async void OnSafetyResourcesClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ADMINResourceUpdate());
    }

    private async void OnUserFeedbackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ViewUserFeedback());
    }
}