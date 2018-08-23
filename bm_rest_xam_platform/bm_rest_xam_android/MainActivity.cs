using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System;
using Shared.ViewModel;

namespace bm_rest_xam_android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private MainActivityViewModel MainActivityVM;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            MainActivityVM = new MainActivityViewModel();

            Button getBtn = FindViewById<Button>(Resource.Id.btn_get);
            getBtn.Click += OnGetClicked;

            Button postBtn = FindViewById<Button>(Resource.Id.btn_post);
            postBtn.Click += OnPostClicked;
        }

        private void OnGetClicked(object sender, EventArgs eventArgs)
        {
            MainActivityVM.GetPersons();
        }

        private void OnPostClicked(object sender, EventArgs eventArgs)
        {
            MainActivityVM.PostPersons();
        }
    }
}

