namespace NEW_REPORT_EASY;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}

    private async void OnCreateAccountClicked(object sender, EventArgs e)
    {
        // TEMPORARY ALERT: NAVIGATING TO MENUPAGE SHOULD ONLY HAPPEN ONCE USER AUTHORIZATION SUCCEEDS. DATABASE ALERT
        await Navigation.PushAsync(new MenuPage());
    }

}