namespace NEW_REPORT_EASY.ADMIN;

public partial class ADMINLogin : ContentPage
{
	public ADMINLogin()
	{
		InitializeComponent();
	}

    private async void OnLogInClicked(object sender, EventArgs e)
    {
        // TEMPORARY ALERT: NAVIGATING TO MENUPAGE SHOULD ONLY HAPPEN ONCE USER AUTHORIZATION SUCCEEDS. DATABASE ALERT
        await Navigation.PushAsync(new ADMINMenu());
    }
}