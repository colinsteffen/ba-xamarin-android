using Shared.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModel
{
    public class UIBenchmarkViewModel 
    {
        public List<Information> InformationItems;

        public UIBenchmarkViewModel()
        {
            InformationItems = new List<Information>();

            for (int i = 0; i < 1000; i++)
                InformationItems.Add(new Information("Paderborn", "Bielefeld"));
        }
    }
}
