using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Shared.ViewModel;

namespace bm_ui_xam_platform.View
{
    [Activity(Label = "UIBenchmarkActivity2", NoHistory = true)]
    public class UIBenchmarkActivity2 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var timer = new Stopwatch();
            timer.Start();

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.actvity_ui_benchmark2);

            timer.Stop();
            System.Diagnostics.Debug.WriteLine("Time: Load -> " + timer.Elapsed);
        }
    }
}