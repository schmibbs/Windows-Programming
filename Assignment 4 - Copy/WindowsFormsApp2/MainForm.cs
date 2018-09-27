//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----[X] Add a status bar. Add a label to the status bar.
//
//----FORM MENU
//----[] Add shortcut keys for all menu items.
//
//----FORM MENU - FILE 
//----[] When focus is on an elliptic child, show the word Ellipse 
//       in the status bar along with the current background color of 
//       the child. Update the status bar when the color changes, too. 
//       Remember that the child may know nothing about the parent.
//----[] When focus is on a rectangular child, show the word Rectangle 
//       in the status bar along with the current background color of the child. 
//       Update the status bar when the color changes, too. Remember that the child 
//       may know nothing about the parent.
//----[] Add an item for opening a custom child. Send the value of the height value and 
//       rectangle ratio value from the preferences to the constructor. When focus is on a 
//       rectangular child, show the word Custom in the status bar along with the current background 
//       color of the child. Update the status bar when the color changes, too. Remember that the child 
//       may know nothing about the parent.
//----[] Add an item for closing all open children. The item should not appear if no children are open.
//
//----LEVEL MENU 'HELP'
//----[X] Add a top level menu named Help.
//----[] Add a menu Oath to the Help menu.
//         + This is not a child form, it is a normal dialog.
//         + When clicked, display a new modal form.
//         + Position the Oath dialog to the right of main window:  the right border of the main 
//           window should abut the left border of the new window; the tops of the windows should be at the same 
//           height from the top of the screen.
//         + Make this an owned form.
//----[] Add a menu item named About to the Help menu.
//         + This is not a child form, it is a normal dialog.
//         + When clicked, display a new modeless form.
//         + Only allow one About dialog to be open at one time.
//         + Position the window below the main window:  the bottom border of the main window should abut 
//           the top border of the new window; the left borders of the windows should be at the same distance from the left edge of the screen.
//         + Make this an owned form.
//----[] Create an icon in the resource editor that contains the initials of one 
//       of the members in the group. Set the icon for the form to the intials icon. 
//       Delete the color icon templates and modify the black and white 32x32 image and 16x16 image.



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
    public partial class MainForm : Form
    {
        public int EllipseWidth { get; set; }
        public int RectangleHeight { get; set; }
        public int EllipseRatio { get; set; }
        public int RectangleRatio { get; set; }

        private List<EllipticChild> ellipticChildren = new List<EllipticChild>();
        private List<RectangelChild> rectangelChildren = new List<RectangelChild>();
        private List<CustomChild> customChildren = new List<CustomChild>();
        public MainForm()
        {
            InitializeComponent();

            EllipseWidth = 50;
            RectangleHeight = 50;
            EllipseRatio = 10;
            RectangleRatio = 10;
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrefrencesDialog prefrencesDialog = new PrefrencesDialog();
            prefrencesDialog.MainForm = this;
            prefrencesDialog.EllipseWidth = EllipseWidth;
            prefrencesDialog.RectangleHeight = RectangleHeight;
            prefrencesDialog.EllipseRatio = EllipseRatio;
            prefrencesDialog.RectangleRatio = RectangleRatio;
            prefrencesDialog.EnbleApplyButton = false;
            prefrencesDialog.ShowDialog();
        }

        private void openPreferencesModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrefrencesDialog prefrencesDialog = new PrefrencesDialog();
            prefrencesDialog.MainForm = this;
            prefrencesDialog.EllipseWidth = EllipseWidth;
            prefrencesDialog.RectangleHeight = RectangleHeight;
            prefrencesDialog.EllipseRatio = EllipseRatio;
            prefrencesDialog.RectangleRatio = RectangleRatio;
            prefrencesDialog.EnbleApplyButton = true;
            prefrencesDialog.Show();
        }

        private void openModallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrefrencesDialog prefrencesDialog = new PrefrencesDialog();
            prefrencesDialog.MainForm = this;
            prefrencesDialog.EllipseWidth = EllipseWidth;
            prefrencesDialog.RectangleHeight = RectangleHeight;
            prefrencesDialog.EllipseRatio = EllipseRatio;
            prefrencesDialog.RectangleRatio = RectangleRatio;
            prefrencesDialog.EnbleApplyButton = false;
            prefrencesDialog.ShowDialog();
        }

        private void openModelesslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrefrencesDialog prefrencesDialog = new PrefrencesDialog();
            prefrencesDialog.MainForm = this;
            prefrencesDialog.EllipseWidth = EllipseWidth;
            prefrencesDialog.RectangleHeight = RectangleHeight;
            prefrencesDialog.EllipseRatio = EllipseRatio;
            prefrencesDialog.RectangleRatio = RectangleRatio;
            prefrencesDialog.EnbleApplyButton = true;
            prefrencesDialog.Show();
        }

        private void openEllipticChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EllipticChild ellipticChild = new EllipticChild(EllipseRatio,EllipseWidth);
            ellipticChild.Show();

            ellipticChildren.Add(ellipticChild);
        }

        private void openRectangularChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangelChild rectangelChild = new RectangelChild(RectangleHeight,RectangleRatio);
            rectangelChild.Show();

            rectangelChildren.Add(rectangelChild);
        }

        private void openCustomChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomChild customChild = new CustomChild(RectangleHeight, RectangleRatio);
            customChild.Show();

            customChildren.Add(customChild);
        }

        private void closeAllEllipticChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form children in ellipticChildren)
            {
                children.Close();
            }
        }

        private void closeAllRectangularChildrenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form children in rectangelChildren)
            {
                children.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close the application?", "Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog aboutDialog = new AboutDialog();
            aboutDialog.Show();
            aboutDialog.Location = new Point(this.Location.X, this.Location.Y + this.Size.Height);
            

            this.AddOwnedForm(aboutDialog);
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
