using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using bm_db_xam_forms.forms.Droid.Helper;
using bm_db_xam_forms.Helper;
using Xamarin.Forms;

[assembly: Dependency(typeof(PathHelper))]
namespace bm_db_xam_forms.forms.Droid.Helper
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