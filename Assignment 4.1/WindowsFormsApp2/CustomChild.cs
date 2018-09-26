//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----CUSTOM CHILD FORM
//----[X] Create a constructor that has a float parameter and an integer.
//----[X] Remove the frame from the form.
//----[*NOT SURE HOW TO IMPLEMENT THIS*] Define the shape of the form so to contains at least one ellipse and one rectangle, 
//       but it may be as complex as you like. The first parameter is the total width of the shape. 
//       The height should be the width multipled by the float parameter.
//----[*UNSURE ABOUT WHAT EXACTLY TO DO*] Set the menu in the base form so that it will merge with any other menu item with the name 
//       Preferences and not appear in the child.

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
using ClassLibrary1;

namespace WindowsFormsApp2
{
    public partial class CustomChild : BaseForm
    {
        public CustomChild()
        {
            InitializeComponent();
            createComplexRegion();
        }

        public CustomChild(float width, int height)
        {
            InitializeComponent();

            this.Width = height;
            this.Height = height * (int) width;

            createComplexRegion();
        }

        public void createComplexRegion()
        {
            Rectangle rect = this.ClientRectangle;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddRectangle(rect);
                path.AddEllipse(rect);
                this.Region = new Region(path);
            }
        }

    }
}
