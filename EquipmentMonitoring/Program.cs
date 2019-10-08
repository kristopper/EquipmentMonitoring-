using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentMonitoring
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a mutex
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, ConstComStr.STR_NAME_MUTEX);
            // Check if already running
            if (mutex.WaitOne(0, false) == false)
            {
                // Find window handles of excecutable programs
                MessageBox.Show(ConstComStr.MSG_04_000, ConstComStr.CAPTION_04_000, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new mainform());

            // Release the mutex
            mutex.ReleaseMutex();
        }
        

            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            /// 
            /*
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainform());
            }
            */
        }
}
