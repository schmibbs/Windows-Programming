using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupInfo
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region bookcodePg69

        Point downPoint = Point.Empty;//from book pg 69

        void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            downPoint = new Point(e.X, e.Y);
        }

        void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
                return;
            Point location = new Point(this.Left + e.X - downPoint.X, this.Top + e.Y - downPoint.Y);

            this.Location = location;
        }

        void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            downPoint = Point.Empty;
        }
        #endregion

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
