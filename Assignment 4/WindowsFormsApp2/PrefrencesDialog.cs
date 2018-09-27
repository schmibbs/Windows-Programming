//----------ASSIGNMENT 4 CHECKLIST----------
//////////////////////////////////////////
//----Preference Dialog
//----[] Display the help icon button in the title bar of the dialog.
//----[] Add tool tips, error providers and help info for each input box and button.
//       Set the help string and tool tip so they include the range of valid numbers.
//----[] Anchor the OK, Apply and Cancel buttons so that they remain in the lower right area of the form when the form is resized.
//----[] When using an interface, it is better to encapsulate actual properties in the dialog or components than to create additional variables.
//----[] Only allow one preferences dialog to be open at a time.
//----[] This is a normal dialog, not an MDI child.
//----[] When the main form is deactivated, make the form partially transparent.When the main form is activated, make the form opaque.
//----[] The dialog may not access any members from the main form, application settings or user settings.

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
    public partial class PrefrencesDialog : BaseDialog
    {
        public bool EnbleApplyButton { get; set; }
        public MainForm MainForm { get; set; }

        public int EllipseWidth { get; set; }
        public int RectangleHeight { get; set; }
        public int EllipseRatio { get; set; }
        public int RectangleRatio { get; set; }

        public PrefrencesDialog()
        {
            InitializeComponent();
        }

        private void PrefrencesDialog_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.Width - panel1.Width) / 2;
            EllipticChild ellipticChild = new EllipticChild();
            ellipticChild.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            EllipseWidthTxt.Text = EllipseWidth.ToString();
            RectangleHeightTxt.Text = RectangleHeight.ToString();
            EllipseRatioTxt.Text = EllipseRatio.ToString();
            RectangleRatioTxt.Text = RectangleRatio.ToString();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.EllipseWidth = Convert.ToInt32(EllipseWidthTxt.Text);
                MainForm.RectangleHeight = Convert.ToInt32(RectangleHeightTxt.Text);
                MainForm.EllipseRatio = Convert.ToInt32(EllipseRatioTxt.Text);
                MainForm.RectangleRatio = Convert.ToInt32(RectangleRatioTxt.Text);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "You've entered invalid values.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.EllipseWidth = Convert.ToInt32(EllipseWidthTxt.Text);
                MainForm.RectangleHeight = Convert.ToInt32(RectangleHeightTxt.Text);
                MainForm.EllipseRatio = Convert.ToInt32(EllipseRatioTxt.Text);
                MainForm.RectangleRatio = Convert.ToInt32(RectangleRatioTxt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "You've entered invalid values.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrefrencesDialog_Load(object sender, EventArgs e)
        {
            applyBtn.Enabled = EnbleApplyButton;
            EllipseWidthTxt.Text = EllipseWidth.ToString();
            RectangleHeightTxt.Text = RectangleHeight.ToString();
            EllipseRatioTxt.Text = EllipseRatio.ToString();
            RectangleRatioTxt.Text = RectangleRatio.ToString();
        }
    }
}
