using bm_db_xam_forms.Database;
using bm_db_xam_forms.Helper;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace bm_db_xam_forms
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

        static DataDatabase database;

        public static DataDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DataDatabase(DependencyService.Get<IPathHelper>().GetLocalPath("db_xam_forms"));
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
