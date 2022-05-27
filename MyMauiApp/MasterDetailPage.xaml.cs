namespace MyMauiApp;

public partial class MasterDetailPage : FlyoutPage
{
	public MasterDetailPage()
	{
		InitializeComponent();

		var listPage = new ListPage() { Title = "ListPageTitle" };
		Flyout = listPage;
		IsPresented = true;

		var detailPage = new MainPage() { Title = "DetailPageTitle" };
		Detail = detailPage;
	}
}
