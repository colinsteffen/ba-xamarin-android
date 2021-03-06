﻿using bm_ui_xam_forms.Helper;
using bm_ui_xam_forms.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bm_ui_xam_forms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnOpenClicked(object sender, EventArgs e)
        {
            TimeHelper.SetStartTime();
            Navigation.PushModalAsync(new UIBenchmarkPage());
        }

        void OnOpen2Clicked(object sender, EventArgs e)
        {
            TimeHelper.SetStartTime();
            Navigation.PushModalAsync(new UIBenchmarkPage2());
        }
    }
}
