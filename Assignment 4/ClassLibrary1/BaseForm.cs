//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----AN ADDITIONAL MENU
//----[] Add an item named Preferences with a subitem named Colors.
//       This option should perform the same action as the context menu Color item.
//----[] Add an item named File with a subitem named Close Child.This should close the form.
//----[] Allow these items to be merged into items with the same name in the MDI parent.
//----[] This menu should not appear in the child. All its items should be merged with the parent at runtime.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class BaseForm : Form
    {
        Point downPoint = Point.Empty;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
        }

        void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            Point location =
            new Point(
              this.Left + e.X - downPoint.X,
              this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }

        void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }
    }
}
