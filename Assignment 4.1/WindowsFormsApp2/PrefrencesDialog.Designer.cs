namespace WindowsFormsApp2
{
    partial class PrefrencesDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrefrencesDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RectangleRatioTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EllipseRatioTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.RectangleHeightTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EllipseWidthTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.RectangleRatioTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EllipseRatioTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Controls.Add(this.RectangleHeightTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EllipseWidthTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 254);
            this.panel1.TabIndex = 5;
            // 
            // RectangleRatioTxt
            // 
            this.RectangleRatioTxt.Location = new System.Drawing.Point(28, 172);
            this.RectangleRatioTxt.Name = "RectangleRatioTxt";
            this.RectangleRatioTxt.Size = new System.Drawing.Size(237, 20);
            this.RectangleRatioTxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Rectangle Ratio:";
            // 
            // EllipseRatioTxt
            // 
            this.EllipseRatioTxt.Location = new System.Drawing.Point(28, 128);
            this.EllipseRatioTxt.Name = "EllipseRatioTxt";
            this.EllipseRatioTxt.Size = new System.Drawing.Size(237, 20);
            this.EllipseRatioTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ellipse Ratio:";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(190, 208);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 6;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(109, 208);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(28, 208);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // RectangleHeightTxt
            // 
            this.RectangleHeightTxt.Location = new System.Drawing.Point(28, 84);
            this.RectangleHeightTxt.Name = "RectangleHeightTxt";
            this.RectangleHeightTxt.Size = new System.Drawing.Size(237, 20);
            this.RectangleHeightTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rectangle Height:";
            // 
            // EllipseWidthTxt
            // 
            this.EllipseWidthTxt.Location = new System.Drawing.Point(28, 40);
            this.EllipseWidthTxt.Name = "EllipseWidthTxt";
            this.EllipseWidthTxt.Size = new System.Drawing.Size(237, 20);
            this.EllipseWidthTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ellipse Width:";
            // 
            // PrefrencesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 455);
            this.Controls.Add(this.panel1);
            this.Name = "PrefrencesDialog";
            this.Text = "Prefrences Dialog";
            this.Load += new System.EventHandler(this.PrefrencesDialog_Load);
            this.Resize += new System.EventHandler(this.PrefrencesDialog_Resize);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RectangleRatioTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EllipseRatioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox RectangleHeightTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EllipseWidthTxt;
        private System.Windows.Forms.Label label1;
    }
}