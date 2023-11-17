namespace NEW_REPORT_EASY
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAdminLoginClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ADMIN.ADMINLogin());
        }
        
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            SemanticScreenReader.Announce(CounterBtn.Text);

            await Navigation.PushAsync(new CreateAccount());
        }

        private async void OnSignInClicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new SignIn());
        }
    }
    }


