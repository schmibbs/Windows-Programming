namespace ClassLibrary1
{
    partial class BaseDialog
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
            this.userControl11 = new ClassLibrary1.UserControl1();
            this.userControl21 = new ClassLibrary1.UserControl2();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(563, 54);
            this.userControl11.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.Transparent;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userControl21.Location = new System.Drawing.Point(0, 179);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(563, 51);
            this.userControl21.TabIndex = 1;
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 230);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Name = "BaseDialog";
            this.Text = "Base Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private UserControl2 userControl21;
    }
}