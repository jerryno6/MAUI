namespace MyMauiApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		//await App.Nav.PushAsync(new MainPage());

		await DisplayAlert("Alert", "You have been alerted", "OK");

	}

	void DisplayPopup_Clicked(System.Object sender, System.EventArgs e)
	{

	}
}
