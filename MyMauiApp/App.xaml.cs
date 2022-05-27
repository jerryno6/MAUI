namespace MyMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		
		MainPage = new MasterDetailPage();
		//MainPage = new AppShell();
	}
}
