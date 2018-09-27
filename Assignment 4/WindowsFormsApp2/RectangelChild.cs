//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----RECTANGULAR CHILD
//----[] Set the menu in the base form so that it will merge with any 
//       other menu item with the name Preferences and not appear in the child.

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class RectangelChild : BaseForm
    {
        public RectangelChild()
        {
            InitializeComponent();
        }

        public RectangelChild(int floatParameter, int _int)
        {
            InitializeComponent();

            this.Height = floatParameter;
            this.Width = this.Height * _int;
        }
    }
}
