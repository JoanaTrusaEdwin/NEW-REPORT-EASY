namespace NEW_REPORT_EASY;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}

    private async void OnSignInClicked(object sender, EventArgs e)
    {
        // TEMPORARY ALERT: NAVIGATING TO MENUPAGE SHOULD ONLY HAPPEN ONCE USER AUTHORIZATION SUCCEEDS. DATABASE ALERT
        await Navigation.PushAsync(new MenuPage());
    }
}