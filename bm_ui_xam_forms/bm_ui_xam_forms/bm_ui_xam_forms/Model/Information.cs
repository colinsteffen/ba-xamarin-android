using System;
using System.Collections.Generic;
using System.Text;

namespace bm_ui_xam_forms.Model
{
    public class Information
    {
        public string Start { get; set; }
        public string End { get; set; }

        public Information(string start, string end)
        {
            this.Start = start;
            this.End = end;
        }

    }
}
