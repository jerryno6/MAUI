namespace MyMauiApp;

public partial class MasterDetailPage : FlyoutPage
{
	public MasterDetailPage()
	{
		InitializeComponent();

		var listPage = new LoginPage() { Title = "LoginPageTitle" };
		this.Flyout = listPage;

		var detailPage = new LoginPage() { Title = "DetailPageTitle" };
		this.Detail = detailPage;
	}
}
