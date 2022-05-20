namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);

#if WINDOWS
		//ExecuteOpenWithPhotoShop();
#endif
	}

	private void ExecuteOpenWithPhotoShop()
	{
		var psexe = @"C:\Program Files\Adobe\Adobe Photoshop 2022\Photoshop.exe";
		var myFile = @"D:\My TIFFs\Test.jpg";

		System.Diagnostics.Process.Start(psexe, myFile);
	}

}

