using bm_db_xam_forms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bm_db_xam_forms
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

        void OnDeleteClicked(object sender, EventArgs e) => MainPageVM.DeleteData();
    }
}
