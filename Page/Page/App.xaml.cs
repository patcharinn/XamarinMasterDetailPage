using Xamarin.Forms;

namespace Page
{
	public partial class App : Application
	{
		public App(string Path)
		{
			InitializeComponent();
			//Application.Current.Properties.Add("path", Path);
			Helpers.Settings.PathSettings = Path;
			MainPage = new LoginPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
