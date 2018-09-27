//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----OATH Dialog
//----[] Use the image resource as the background image.
//----[X] Extend from the base dialog in the control library.
//----[] Add the oath control.Center it in the panel in the base dialog.
//----[] The dialog should be a fixed size.Remove the icon, minimize button and maximize button.

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
    public partial class OathDialog : BaseDialog
    {
        public OathDialog()
        {
            InitializeComponent();
        }
    }
}
