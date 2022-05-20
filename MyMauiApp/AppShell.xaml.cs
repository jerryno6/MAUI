namespace MyMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	// UnComment the below method to handle Shell Menu item click event
	// And ensure appropriate page definitions are available for it work as expected

	private async void OnMenuItemLogoutClicked(object sender, EventArgs e)
	{
		await Current.GoToAsync("//login");
	}

}
