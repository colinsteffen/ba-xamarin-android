using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Shared.ViewModel;

namespace bm_json_xam_android
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
        private MainActivityViewModel MainActivityVM;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.activity_main);

            MainActivityVM = new MainActivityViewModel();

            Button serializeBtn = FindViewById<Button>(Resource.Id.btn_serialize);
            serializeBtn.Click += OnSerializedClicked;

            Button deserializeBtn = FindViewById<Button>(Resource.Id.btn_deserialize);
            deserializeBtn.Click += OnDeserializedClicked;
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

        private void OnSerializedClicked(object sender, EventArgs eventArgs)
        {
            MainActivityVM.SerializePersons();
        }

        private void OnDeserializedClicked(object sender, EventArgs eventArgs)
        {
            MainActivityVM.DeserializePersons();
        }
    }
}

