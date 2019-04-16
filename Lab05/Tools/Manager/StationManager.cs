using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab05.Tools.Manager
{
    internal static class StationManager
    {
        public static event Action StopThreads;

        internal static void CloseApp()
        {
            MessageBox.Show("Stop");
            try
            {
                StopThreads?.Invoke();
            }
            catch
            {

            }
            Environment.Exit(1);
        }
    }
}
