using bm_json_xam_forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bm_json_xam_forms
{
    public partial class MainPage : ContentPage
	{
        private MainPageViewModel MainPageVM;
        public MainPage()
		{
            MainPageVM = new MainPageViewModel();
            InitializeComponent();
		}

        void OnSerializedClicked(object sender, EventArgs e) => MainPageVM.SerializePersons();

        void OnDeserializedClicked(object sender, EventArgs e) => MainPageVM.DeserializePersons();
    }
}
