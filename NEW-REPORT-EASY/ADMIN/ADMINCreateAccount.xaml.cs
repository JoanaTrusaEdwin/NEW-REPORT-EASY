namespace NEW_REPORT_EASY.ADMIN;

public partial class ADMINCreateAccount : ContentPage
{
	public ADMINCreateAccount()
	{
		InitializeComponent();
	}

    private async void OnCreateAccountClicked(object sender, EventArgs e)
    {
        // TEMPORARY ALERT: NAVIGATING TO MENUPAGE SHOULD ONLY HAPPEN ONCE USER AUTHORIZATION SUCCEEDS. DATABASE ALERT
        await Navigation.PushAsync(new ADMINMenu());
    }
}