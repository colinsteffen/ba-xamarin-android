using bm_rest_xam_forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bm_rest_xam_forms
{
	public partial class MainPage : ContentPage
	{
        private MainPageViewModel MainPageVM;
		public MainPage()
		{
			InitializeComponent();
		}

        void OnGetClicked(object sender, EventArgs e) => MainPageVM.GetPersons();

        void OnPostClicked(object sender, EventArgs e) => MainPageVM.PostPersons();
    }
}
