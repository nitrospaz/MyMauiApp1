namespace MauiApp1;

public partial class LayoutExample : ContentPage
{
	public LayoutExample()
	{
		InitializeComponent();

		// Set padding for the StackLayout based on the device platform
		VStackLayout.Padding = DeviceInfo.Platform == DevicePlatform.iOS ? new Thickness(30, 10, 30, 0) : new Thickness(25);
	}
}