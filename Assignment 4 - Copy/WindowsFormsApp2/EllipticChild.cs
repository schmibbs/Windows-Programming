//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----ELLIPTICAL CHILD
//----[] Set the menu in the base form so that it will merge with any 
//       other menu item with the name Preferences and not appear in the child.

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EllipticChild : BaseForm
    {
        public EllipticChild()
        {
            InitializeComponent();
            createEllipticalRegion();
        }

        public EllipticChild(int floatParameter, int _int)
        {
            InitializeComponent();

            this.Width = _int;
            this.Height = _int * floatParameter;

            createEllipticalRegion();
        }

        public void createEllipticalRegion() {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }
        }
    }
}
