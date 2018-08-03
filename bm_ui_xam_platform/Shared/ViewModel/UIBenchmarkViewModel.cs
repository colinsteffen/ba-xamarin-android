using Shared.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ViewModel
{
    public class UIBenchmarkViewModel 
    {
        public List<Information> InformationItems = new List<Information>();

        public UIBenchmarkViewModel()
        {
            for (int i = 0; i < 1000; i++)
                InformationItems.Add(new Information("Paderborn", "Bielefeld"));
        }
    }
}
