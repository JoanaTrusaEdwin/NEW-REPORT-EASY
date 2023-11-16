namespace NEW_REPORT_EASY.ADMIN;

public partial class ADMINResourceUpdate : ContentPage
{
    public ADMINResourceUpdate()
    {
        InitializeComponent();
    }

    private async void OnChooseFileClicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                FileTypes = FilePickerFileType.Pdf,
                PickerTitle = "Select a file"
            });

            if (result != null)
            {
                // Handle the selected file
                var stream = await result.OpenReadAsync();
                // Perform actions with the file stream
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions
        }
    }
}