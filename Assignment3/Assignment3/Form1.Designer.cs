namespace Assignment3
{
    partial class Root
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
            this.components = new System.ComponentModel.Container();
            this.asdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preferences = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModelesslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Preferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // asdfToolStripMenuItem
            // 
            this.asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            this.asdfToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.asdfToolStripMenuItem.Text = "asdf";
            // 
            // fdsaToolStripMenuItem
            // 
            this.fdsaToolStripMenuItem.Name = "fdsaToolStripMenuItem";
            this.fdsaToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.fdsaToolStripMenuItem.Text = "fdsa";
            // 
            // Preferences
            // 
            this.Preferences.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem,
            this.openPreferencesModelesslyToolStripMenuItem});
            this.Preferences.Name = "Preferences";
            this.Preferences.Size = new System.Drawing.Size(230, 48);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModelesslyToolStripMenuItem
            // 
            this.openPreferencesModelesslyToolStripMenuItem.Name = "openPreferencesModelesslyToolStripMenuItem";
            this.openPreferencesModelesslyToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.openPreferencesModelesslyToolStripMenuItem.Text = "Open Preferences Modelessly";
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.ContextMenuStrip = this.Preferences;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Root";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Preferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem asdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fdsaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Preferences;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModelesslyToolStripMenuItem;
    }
}

