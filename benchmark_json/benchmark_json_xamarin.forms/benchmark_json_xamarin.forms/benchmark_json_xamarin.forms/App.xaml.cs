using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using benchmark_json_xamarin.forms.Database;
using benchmark_json_xamarin.forms.Helper;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace benchmark_json_xamarin.forms
{
	public partial class App : Application
	{
        static DataDatabase database;
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

        public static DataDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new DataDatabase(DependencyService.Get<IPathHelper>().GetLocalPath("xamarin_forms.db"));
                }
                return database;
            }
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
