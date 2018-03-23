using PCLAppConfig;
using System.Reflection;

using Xamarin.Forms;

namespace XamarinConfig
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            Assembly assembly = typeof(App).GetTypeInfo().Assembly;
            ConfigurationManager.Initialise(assembly.GetManifestResourceStream("XamarinConfig.App.config"));

            MainPage = new XamarinConfig.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
