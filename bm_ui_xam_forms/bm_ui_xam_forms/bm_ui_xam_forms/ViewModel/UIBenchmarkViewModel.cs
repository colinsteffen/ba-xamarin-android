using bm_ui_xam_forms.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace bm_ui_xam_forms.ViewModel
{
    public class UIBenchmarkViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Information> _informationItems = new ObservableCollection<Information>();

        public UIBenchmarkViewModel()
        {
            for (int i = 0; i < 1000; i++)
                _informationItems.Add(new Information("Paderborn", "Bielefeld"));
        }

        public ObservableCollection<Information> InformationItems
        {
            get { return _informationItems; }
            set
            {
                _informationItems = value;
                OnPropertyChanged("InformationItems");
            }
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
