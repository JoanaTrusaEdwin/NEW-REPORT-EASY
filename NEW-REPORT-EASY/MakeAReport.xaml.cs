namespace NEW_REPORT_EASY;

public partial class MakeAReport : ContentPage
{

    //DATABASE ALERT
	public MakeAReport()
	{
		InitializeComponent();
	}

    private async void OnCapturePhotoClicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.CapturePhotoAsync();
        
    }

    private async void OnUploadFromGalleryClicked(object sender, EventArgs e)
    {
        var result = await MediaPicker.PickPhotoAsync();
       
    }

    private void OnSubmitReportClicked(object sender, EventArgs e)
    {
        //TEMPORARY ALERT: PLS VALIDATE THE DATA TO DATABASE
        Navigation.PushAsync(new MyReports());
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