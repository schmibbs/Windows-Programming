namespace GroupInfo
{
    partial class CourseInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MemberNames = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberNames
            // 
            this.MemberNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberNames.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNames.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MemberNames.Location = new System.Drawing.Point(0, 26);
            this.MemberNames.MaxLength = 0;
            this.MemberNames.Name = "MemberNames";
            this.MemberNames.ReadOnly = true;
            this.MemberNames.Size = new System.Drawing.Size(360, 23);
            this.MemberNames.TabIndex = 1;
            this.MemberNames.Text = "Fall 2018";
            this.MemberNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemberNames);
            this.panel1.Controls.Add(this.GroupName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 76);
            this.panel1.TabIndex = 2;
            // 
            // GroupName
            // 
            this.GroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupName.Location = new System.Drawing.Point(0, 0);
            this.GroupName.MaxLength = 0;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Size = new System.Drawing.Size(360, 26);
            this.GroupName.TabIndex = 0;
            this.GroupName.Text = "Advanced Windows Programming";
            this.GroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.panel1);
            this.Name = "CourseInfo";
            this.Size = new System.Drawing.Size(360, 76);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox MemberNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GroupName;
    }
}
