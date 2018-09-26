namespace GroupInfo
{
    partial class GroupAndMemberNames
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
            this.GroupName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemberNames = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupName
            // 
            this.GroupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupName.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupName.Location = new System.Drawing.Point(0, 0);
            this.GroupName.MaxLength = 0;
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Size = new System.Drawing.Size(304, 31);
            this.GroupName.TabIndex = 0;
            this.GroupName.Text = "Group 4";
            this.GroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GroupName.TextChanged += new System.EventHandler(this.GroupName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MemberNames);
            this.panel1.Controls.Add(this.GroupName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 67);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MemberNames
            // 
            this.MemberNames.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberNames.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberNames.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MemberNames.Location = new System.Drawing.Point(0, 31);
            this.MemberNames.MaxLength = 0;
            this.MemberNames.Name = "MemberNames";
            this.MemberNames.ReadOnly = true;
            this.MemberNames.Size = new System.Drawing.Size(304, 26);
            this.MemberNames.TabIndex = 1;
            this.MemberNames.Text = "Eric, Joseph, Jose, Jorge, Mehdi, Otto";
            this.MemberNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MemberNames.TextChanged += new System.EventHandler(this.MemberNames_TextChanged);
            // 
            // GroupAndMemberNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Controls.Add(this.panel1);
            this.Name = "GroupAndMemberNames";
            this.Size = new System.Drawing.Size(310, 64);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox MemberNames;
    }
}
