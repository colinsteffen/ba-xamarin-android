using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace bm_ui_xam_forms.Helper
{
    public static class TimeHelper
    {
        private static Stopwatch timer;

        public static void SetStartTime()
        {
            timer = new Stopwatch();
            timer.Start();
        }

        public static void SetEndTime()
        {
            timer.Stop();
            Debug.WriteLine("Time: Load -> " + timer.Elapsed);
        }
    }
}
