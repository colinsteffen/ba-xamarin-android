using bm_ui_xam_forms.Helper;
using bm_ui_xam_forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bm_ui_xam_forms.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UIBenchmarkPage2 : ContentPage
	{
		public UIBenchmarkPage2 ()
		{
            InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            TimeHelper.SetEndTime();
        }
    }
}