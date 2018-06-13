﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using benchmark_json_xamarin.forms.Helper;
using System.IO;
using benchmark_json_xamarin.forms.Droid.Helper;

[assembly: Dependency(typeof(PathHelper))]
namespace benchmark_json_xamarin.forms.Droid.Helper
{
    public class PathHelper : IPathHelper
    {
        public string GetLocalPath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}