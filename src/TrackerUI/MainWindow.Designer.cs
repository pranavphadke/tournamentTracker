namespace TrackerUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainWindowTabControl = new System.Windows.Forms.TabControl();
            this.tournamentDashboardTab = new System.Windows.Forms.TabPage();
            this.tournamentCreatorTab = new System.Windows.Forms.TabPage();
            this.teamCreatorTab = new System.Windows.Forms.TabPage();
            this.prizeCreatorTab = new System.Windows.Forms.TabPage();
            this.mainWindowTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowTabControl
            // 
            this.mainWindowTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainWindowTabControl.Controls.Add(this.tournamentDashboardTab);
            this.mainWindowTabControl.Controls.Add(this.tournamentCreatorTab);
            this.mainWindowTabControl.Controls.Add(this.teamCreatorTab);
            this.mainWindowTabControl.Controls.Add(this.prizeCreatorTab);
            this.mainWindowTabControl.Location = new System.Drawing.Point(-2, 0);
            this.mainWindowTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainWindowTabControl.Name = "mainWindowTabControl";
            this.mainWindowTabControl.Padding = new System.Drawing.Point(0, 0);
            this.mainWindowTabControl.SelectedIndex = 0;
            this.mainWindowTabControl.Size = new System.Drawing.Size(558, 576);
            this.mainWindowTabControl.TabIndex = 0;
            this.mainWindowTabControl.SelectedIndexChanged += new System.EventHandler(this.mainWindowTabControl_SelectedIndexChanged);
            // 
            // tournamentDashboardTab
            // 
            this.tournamentDashboardTab.Location = new System.Drawing.Point(4, 22);
            this.tournamentDashboardTab.Margin = new System.Windows.Forms.Padding(0);
            this.tournamentDashboardTab.Name = "tournamentDashboardTab";
            this.tournamentDashboardTab.Size = new System.Drawing.Size(550, 550);
            this.tournamentDashboardTab.TabIndex = 0;
            this.tournamentDashboardTab.Text = "Dashboard";
            this.tournamentDashboardTab.UseVisualStyleBackColor = true;
            // 
            // tournamentCreatorTab
            // 
            this.tournamentCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.tournamentCreatorTab.Margin = new System.Windows.Forms.Padding(0);
            this.tournamentCreatorTab.Name = "tournamentCreatorTab";
            this.tournamentCreatorTab.Size = new System.Drawing.Size(550, 550);
            this.tournamentCreatorTab.TabIndex = 1;
            this.tournamentCreatorTab.Text = "Tournaments";
            this.tournamentCreatorTab.UseVisualStyleBackColor = true;
            // 
            // teamCreatorTab
            // 
            this.teamCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.teamCreatorTab.Margin = new System.Windows.Forms.Padding(0);
            this.teamCreatorTab.Name = "teamCreatorTab";
            this.teamCreatorTab.Size = new System.Drawing.Size(550, 550);
            this.teamCreatorTab.TabIndex = 2;
            this.teamCreatorTab.Text = "Teams";
            this.teamCreatorTab.UseVisualStyleBackColor = true;
            // 
            // prizeCreatorTab
            // 
            this.prizeCreatorTab.Location = new System.Drawing.Point(4, 22);
            this.prizeCreatorTab.Margin = new System.Windows.Forms.Padding(0);
            this.prizeCreatorTab.Name = "prizeCreatorTab";
            this.prizeCreatorTab.Size = new System.Drawing.Size(550, 550);
            this.prizeCreatorTab.TabIndex = 4;
            this.prizeCreatorTab.Text = "Prizes";
            this.prizeCreatorTab.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 573);
            this.Controls.Add(this.mainWindowTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Tracker";
            this.TopMost = true;
            this.mainWindowTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainWindowTabControl;
        private System.Windows.Forms.TabPage tournamentDashboardTab;
        private System.Windows.Forms.TabPage tournamentCreatorTab;
        private System.Windows.Forms.TabPage teamCreatorTab;
        private System.Windows.Forms.TabPage prizeCreatorTab;
    }
}