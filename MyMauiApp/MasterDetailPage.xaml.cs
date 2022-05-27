namespace MyMauiApp;

public partial class MasterDetailPage : FlyoutPage
{
	public MasterDetailPage()
	{
		InitializeComponent();

		var listPage = new ListPage() { Title = "ListPageTitle" };
		Flyout = listPage;
		//IsPresented = true;//this line also causes crash on MAC

		var detailPage = new MainPage() { Title = "DetailPageTitle" };
		Detail = detailPage;
	}
}
