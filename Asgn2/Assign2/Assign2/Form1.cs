using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            //check for a name entered
            if (((Control)sender).Text.Trim().Length == 0) 
                MessageBox.Show("Please enter a name", "Error");

            //check if user entered a space and reset their input if they did
            else
            {
                while (i++ < ((Control)sender).Text.Length-1) //Length idea source: https://syntaxdb.com/ref/csharp/string-length
                {
                    if (((Control)sender).Text[i].Equals(' '))
                    {
                        MessageBox.Show("Name cannot contain a space", "Error");
                        ((Control)sender).Text = "";
                    }
                }
            }

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Button saveButton = sender as Button;
            MessageBox.Show("Size should be saved (isn't yet)");
            //Properties.Settings.Default.UserSize.save();
        }

        private void Location_Click(object sender, EventArgs e)
        {
            Button locationButton = sender as Button;
            MessageBox.Show("Location should be saved (isn't yet)");
            //Properties.Settings.Default.UserLocation.save();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Button resetButton = sender as Button;
            MessageBox.Show("Size + Location should be reset (isn't yet)");
            //Properties.Settings.Default.UserSize.Reset();
            //Properties.Settings.Default.UserLocation.Reset();
        }
    }
}
