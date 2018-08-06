using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;
using bm_ui_xam_platform.View;
using Android.Content.PM;

namespace bm_ui_xam_platform
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, WindowSoftInputMode = SoftInput.AdjustResize)]
	public class MainActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

			Button btn = FindViewById<Button>(Resource.Id.btn_open_activity);
            btn.Click += OpenActivity;

            Button btn2 = FindViewById<Button>(Resource.Id.btn_open_activity2);
            btn2.Click += OpenActivity2;
        }

        private void OpenActivity(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(UIBenchmarkActivity));
            StartActivity(intent);
        }

        private void OpenActivity2(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(UIBenchmarkActivity2));
            StartActivity(intent);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }
	}
}

