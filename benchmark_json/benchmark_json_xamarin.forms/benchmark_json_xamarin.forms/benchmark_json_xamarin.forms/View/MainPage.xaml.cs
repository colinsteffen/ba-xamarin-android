using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using benchmark_json_xamarin.forms.ViewModel;

namespace benchmark_json_xamarin.forms
{
	public partial class MainPage : ContentPage
	{
        private MainPageViewModel MainPageVM;
        public MainPage()
		{
            MainPageVM = new MainPageViewModel();
			InitializeComponent();
		}

        void OnInsertClicked(object sender, EventArgs e) => MainPageVM.InsertData();

        void OnResetClicked(object sender, EventArgs e) => MainPageVM.ResetList();

        void OnLoadClicked(object sender, EventArgs e) => MainPageVM.LoadData();
    }
}
