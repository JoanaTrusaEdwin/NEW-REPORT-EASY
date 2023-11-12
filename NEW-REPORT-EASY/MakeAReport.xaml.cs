namespace NEW_REPORT_EASY;

public partial class MakeAReport : ContentPage
{
	public MakeAReport()
	{
		InitializeComponent();
	}

    private async void OnCapturePhotoClicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.CapturePhotoAsync();
        // Process the captured photo (result) as needed
    }

    private async void OnUploadFromGalleryClicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.PickPhotoAsync();
        // Process the picked photo (result) as needed
    }

    private void OnSubmitReportClicked(object sender, EventArgs e)
    {
        // Handle Submit Report button click
    }

    private void OnSaveAsDraftClicked(object sender, EventArgs e)
    {
        // Handle Save as Draft button click
    }


    //private void OnStreetPickerSelectedIndexChanged(object sender, EventArgs e)
    //{
    //    var picker = (Picker)sender; // Cast the sender to Picker
    //    var selectedStreet = picker.SelectedItem as string;

    //    if (selectedStreet == "Other")
    //    {
    //        otherStreetEntry.IsVisible = true;
    //    }
    //    else
    //    {
    //        otherStreetEntry.IsVisible = false;
    //    }
    //}
}