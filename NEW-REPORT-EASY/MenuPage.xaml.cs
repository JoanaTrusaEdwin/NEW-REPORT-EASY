namespace NEW_REPORT_EASY;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}

    private async void OnMakeReportClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MakeAReport());
    }

    private async void OnMyProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MyProfile());
    }

    private async void OnMyReportsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MyReports());
    }

}