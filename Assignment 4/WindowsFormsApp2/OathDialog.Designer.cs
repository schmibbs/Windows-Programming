namespace WindowsFormsApp2
{
    partial class OathDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl31 = new ClassLibrary1.UserControl3();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.userControl31);
            this.panel1.Location = new System.Drawing.Point(176, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 135);
            this.panel1.TabIndex = 2;
            // 
            // userControl31
            // 
            this.userControl31.AutoScroll = true;
            this.userControl31.BackColor = System.Drawing.Color.Transparent;
            this.userControl31.Location = new System.Drawing.Point(77, 67);
            this.userControl31.Margin = new System.Windows.Forms.Padding(2);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(298, 66);
            this.userControl31.TabIndex = 0;
            // 
            // OathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.New_wallpaper_perhaps;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "OathDialog";
            this.Text = "OathDialog";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ClassLibrary1.UserControl3 userControl31;
    }
}