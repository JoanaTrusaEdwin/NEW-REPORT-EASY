namespace NEW_REPORT_EASY;

public partial class CreateAccount : ContentPage
{
	public CreateAccount()
	{
		InitializeComponent();
	}

    private async void OnCreateAccountClicked(object sender, EventArgs e)
    {
        // Add your account creation logic here
        await Navigation.PushAsync(new MenuPage());
    }

}