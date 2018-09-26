//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----About Dialog
//----[] Use the image resource as the background image.
//----[X] Extend from the base dialog in the control library.
//----[X] Add a description of the assignment.Center it in the panel in the base dialog.
//----[X] The dialog should be a fixed size.Remove the icon, minimize button and maximize button.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp2
{
    public partial class AboutDialog : BaseDialog
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
