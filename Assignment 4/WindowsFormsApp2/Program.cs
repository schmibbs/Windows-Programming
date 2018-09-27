//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----Login Dialog
//----[] Before the application is run, display a warning dialog with the buttons Yes and No. 
//       Make up a creative warning for users that are about to run your code.
//----[] If the user selects Yes, then proceed to run the application.If the user selects No, then do not call Application.Run.
//----[] Add a checkbox that allows the user to skip this screen in the future.
//----------[] Save the preference in a user setting.
//----------[] When the app is started, skip the login dialog if the preference is set.
//----------[] Add an appropriate menu item to allow the user see the login screen again.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
