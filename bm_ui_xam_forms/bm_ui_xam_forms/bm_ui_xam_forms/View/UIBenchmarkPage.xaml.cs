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
	public partial class UIBenchmarkPage : ContentPage
	{
        UIBenchmarkViewModel uIBenchmarkMV;
		public UIBenchmarkPage ()
		{
            uIBenchmarkMV = new UIBenchmarkViewModel();

            var timer = new Stopwatch();
            timer.Start();

            InitializeComponent();
            BindingContext = uIBenchmarkMV;

            timer.Stop();
            Debug.WriteLine("Time: Load -> " + timer.Elapsed);
		}
	}
}