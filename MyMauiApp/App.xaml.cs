namespace MyMauiApp;

public partial class App : Application
{
	public static NavigationPage Nav { get; set; }
	public App()
	{
		InitializeComponent();

		Nav = new NavigationPage(new LoginPage() { Title = "LoginPageTitle" }) { Title = "NavigationTitle" };
		MainPage = Nav; 
	}
}
