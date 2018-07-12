using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using bm_db_xam_shared.ViewModel;

namespace bm_db_xam_android
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
        private MainActivityViewModel MainActivityController;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            MainActivityController = new MainActivityViewModel();

			Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

			Button insertBtn = FindViewById<Button>(Resource.Id.btn_insert);
            insertBtn.Click += OnInsertClicked;

            Button resetBtn = FindViewById<Button>(Resource.Id.btn_reset);
            resetBtn.Click += OnResetClicked;

            Button loadBtn = FindViewById<Button>(Resource.Id.btn_load);
            loadBtn.Click += OnLoadClicked;

            Button deleteBtn = FindViewById<Button>(Resource.Id.btn_delete);
            deleteBtn.Click += OnDeleteClicked;
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

        private void OnInsertClicked(object sender, EventArgs eventArgs)
        {
            MainActivityController.InsertData();
        }

        private void OnResetClicked(object sender, EventArgs eventArgs)
        {
            MainActivityController.ResetList();
        }

        private void OnLoadClicked(object sender, EventArgs eventArgs)
        {
            MainActivityController.LoadData();
        }

        private void OnDeleteClicked(object sender, EventArgs eventArgs)
        {
            MainActivityController.DeleteData();
        }
    }
}

