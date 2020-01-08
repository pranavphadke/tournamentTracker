namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.roundNumberLabel = new System.Windows.Forms.Label();
            this.roundNumberComboBox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupNameLabel = new System.Windows.Forms.Label();
            this.matchupNameComboBox = new System.Windows.Forms.ComboBox();
            this.team1NameLabel = new System.Windows.Forms.Label();
            this.team2NameLabel = new System.Windows.Forms.Label();
            this.winningTeamNameLabel = new System.Windows.Forms.Label();
            this.team1ScoreTextBox = new System.Windows.Forms.TextBox();
            this.team2ScoreTextBox = new System.Windows.Forms.TextBox();
            this.updateScoreButton = new System.Windows.Forms.Button();
            this.jumpCreateTournamentButton = new System.Windows.Forms.Button();
            this.tournamentNameComboBox = new System.Windows.Forms.ComboBox();
            this.scoreUpdateGroupBox = new System.Windows.Forms.GroupBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreUpdateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(14, 57);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(146, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament :";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundNumberLabel
            // 
            this.roundNumberLabel.AutoSize = true;
            this.roundNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundNumberLabel.Location = new System.Drawing.Point(17, 188);
            this.roundNumberLabel.Name = "roundNumberLabel";
            this.roundNumberLabel.Size = new System.Drawing.Size(92, 32);
            this.roundNumberLabel.TabIndex = 2;
            this.roundNumberLabel.Text = "Round :";
            this.roundNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundNumberComboBox
            // 
            this.roundNumberComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundNumberComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundNumberComboBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNumberComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.roundNumberComboBox.FormattingEnabled = true;
            this.roundNumberComboBox.Location = new System.Drawing.Point(113, 184);
            this.roundNumberComboBox.Name = "roundNumberComboBox";
            this.roundNumberComboBox.Size = new System.Drawing.Size(50, 40);
            this.roundNumberComboBox.TabIndex = 3;
            this.roundNumberComboBox.Text = "-";
            this.roundNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.roundNumberComboBox_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(343, 194);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(169, 25);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Only show unplayed?";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckBox_CheckedChanged);
            // 
            // matchupNameLabel
            // 
            this.matchupNameLabel.AutoSize = true;
            this.matchupNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matchupNameLabel.Location = new System.Drawing.Point(169, 188);
            this.matchupNameLabel.Name = "matchupNameLabel";
            this.matchupNameLabel.Size = new System.Drawing.Size(116, 32);
            this.matchupNameLabel.TabIndex = 6;
            this.matchupNameLabel.Text = "Matchup :";
            this.matchupNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matchupNameComboBox
            // 
            this.matchupNameComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.matchupNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchupNameComboBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupNameComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.matchupNameComboBox.FormattingEnabled = true;
            this.matchupNameComboBox.Location = new System.Drawing.Point(287, 184);
            this.matchupNameComboBox.Name = "matchupNameComboBox";
            this.matchupNameComboBox.Size = new System.Drawing.Size(47, 40);
            this.matchupNameComboBox.TabIndex = 7;
            this.matchupNameComboBox.Text = "-";
            this.matchupNameComboBox.SelectedIndexChanged += new System.EventHandler(this.matchupNameComboBox_SelectedIndexChanged);
            // 
            // team1NameLabel
            // 
            this.team1NameLabel.AutoSize = true;
            this.team1NameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1NameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.team1NameLabel.Location = new System.Drawing.Point(83, 35);
            this.team1NameLabel.Name = "team1NameLabel";
            this.team1NameLabel.Size = new System.Drawing.Size(25, 32);
            this.team1NameLabel.TabIndex = 8;
            this.team1NameLabel.Text = "-";
            this.team1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // team2NameLabel
            // 
            this.team2NameLabel.AutoSize = true;
            this.team2NameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2NameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.team2NameLabel.Location = new System.Drawing.Point(83, 176);
            this.team2NameLabel.Name = "team2NameLabel";
            this.team2NameLabel.Size = new System.Drawing.Size(25, 32);
            this.team2NameLabel.TabIndex = 9;
            this.team2NameLabel.Text = "-";
            this.team2NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // winningTeamNameLabel
            // 
            this.winningTeamNameLabel.AutoSize = true;
            this.winningTeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningTeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.winningTeamNameLabel.Location = new System.Drawing.Point(290, 106);
            this.winningTeamNameLabel.Name = "winningTeamNameLabel";
            this.winningTeamNameLabel.Size = new System.Drawing.Size(26, 32);
            this.winningTeamNameLabel.TabIndex = 10;
            this.winningTeamNameLabel.Text = "-";
            this.winningTeamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // team1ScoreTextBox
            // 
            this.team1ScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team1ScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1ScoreTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.team1ScoreTextBox.Location = new System.Drawing.Point(24, 37);
            this.team1ScoreTextBox.Name = "team1ScoreTextBox";
            this.team1ScoreTextBox.Size = new System.Drawing.Size(53, 29);
            this.team1ScoreTextBox.TabIndex = 11;
            this.team1ScoreTextBox.Text = "-";
            this.team1ScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // team2ScoreTextBox
            // 
            this.team2ScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team2ScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2ScoreTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.team2ScoreTextBox.Location = new System.Drawing.Point(24, 178);
            this.team2ScoreTextBox.Name = "team2ScoreTextBox";
            this.team2ScoreTextBox.Size = new System.Drawing.Size(53, 29);
            this.team2ScoreTextBox.TabIndex = 12;
            this.team2ScoreTextBox.Text = "-";
            this.team2ScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateScoreButton
            // 
            this.updateScoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateScoreButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updateScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateScoreButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateScoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateScoreButton.Location = new System.Drawing.Point(423, 170);
            this.updateScoreButton.Name = "updateScoreButton";
            this.updateScoreButton.Size = new System.Drawing.Size(75, 57);
            this.updateScoreButton.TabIndex = 13;
            this.updateScoreButton.Text = "Update\r\nScore";
            this.updateScoreButton.UseVisualStyleBackColor = true;
            this.updateScoreButton.Click += new System.EventHandler(this.updateScoreButton_Click);
            // 
            // jumpCreateTournamentButton
            // 
            this.jumpCreateTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpCreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpCreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.jumpCreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.jumpCreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jumpCreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpCreateTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpCreateTournamentButton.Location = new System.Drawing.Point(265, 135);
            this.jumpCreateTournamentButton.Name = "jumpCreateTournamentButton";
            this.jumpCreateTournamentButton.Size = new System.Drawing.Size(146, 22);
            this.jumpCreateTournamentButton.TabIndex = 14;
            this.jumpCreateTournamentButton.Text = "Create a new tournament";
            this.jumpCreateTournamentButton.UseVisualStyleBackColor = true;
            this.jumpCreateTournamentButton.Click += new System.EventHandler(this.jumpCreateTournamentButton_Click);
            // 
            // tournamentNameComboBox
            // 
            this.tournamentNameComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tournamentNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentNameComboBox.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold);
            this.tournamentNameComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameComboBox.FormattingEnabled = true;
            this.tournamentNameComboBox.Location = new System.Drawing.Point(164, 54);
            this.tournamentNameComboBox.Name = "tournamentNameComboBox";
            this.tournamentNameComboBox.Size = new System.Drawing.Size(348, 40);
            this.tournamentNameComboBox.TabIndex = 15;
            this.tournamentNameComboBox.Text = "-";
            this.tournamentNameComboBox.SelectedIndexChanged += new System.EventHandler(this.tournamentNameComboBox_SelectedIndexChanged);
            // 
            // scoreUpdateGroupBox
            // 
            this.scoreUpdateGroupBox.Controls.Add(this.label1);
            this.scoreUpdateGroupBox.Controls.Add(this.versusLabel);
            this.scoreUpdateGroupBox.Controls.Add(this.updateScoreButton);
            this.scoreUpdateGroupBox.Controls.Add(this.team1NameLabel);
            this.scoreUpdateGroupBox.Controls.Add(this.team2NameLabel);
            this.scoreUpdateGroupBox.Controls.Add(this.winningTeamNameLabel);
            this.scoreUpdateGroupBox.Controls.Add(this.team2ScoreTextBox);
            this.scoreUpdateGroupBox.Controls.Add(this.team1ScoreTextBox);
            this.scoreUpdateGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreUpdateGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreUpdateGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.scoreUpdateGroupBox.Location = new System.Drawing.Point(14, 258);
            this.scoreUpdateGroupBox.Name = "scoreUpdateGroupBox";
            this.scoreUpdateGroupBox.Size = new System.Drawing.Size(510, 241);
            this.scoreUpdateGroupBox.TabIndex = 16;
            this.scoreUpdateGroupBox.TabStop = false;
            this.scoreUpdateGroupBox.Text = "Score update";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.versusLabel.Location = new System.Drawing.Point(61, 106);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(44, 32);
            this.versusLabel.TabIndex = 14;
            this.versusLabel.Text = "v/s";
            this.versusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.orLabel.Location = new System.Drawing.Point(320, 103);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(37, 17);
            this.orLabel.TabIndex = 16;
            this.orLabel.Text = "- or -";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 45);
            this.label2.TabIndex = 17;
            this.label2.Text = "Dashboard";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(191, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Winner :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.scoreUpdateGroupBox);
            this.Controls.Add(this.tournamentNameComboBox);
            this.Controls.Add(this.jumpCreateTournamentButton);
            this.Controls.Add(this.matchupNameComboBox);
            this.Controls.Add(this.matchupNameLabel);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundNumberComboBox);
            this.Controls.Add(this.roundNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.scoreUpdateGroupBox.ResumeLayout(false);
            this.scoreUpdateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label roundNumberLabel;
        private System.Windows.Forms.ComboBox roundNumberComboBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.Label matchupNameLabel;
        private System.Windows.Forms.ComboBox matchupNameComboBox;
        private System.Windows.Forms.Label team1NameLabel;
        private System.Windows.Forms.Label team2NameLabel;
        private System.Windows.Forms.Label winningTeamNameLabel;
        private System.Windows.Forms.TextBox team1ScoreTextBox;
        private System.Windows.Forms.TextBox team2ScoreTextBox;
        private System.Windows.Forms.Button updateScoreButton;
        private System.Windows.Forms.Button jumpCreateTournamentButton;
        private System.Windows.Forms.ComboBox tournamentNameComboBox;
        private System.Windows.Forms.GroupBox scoreUpdateGroupBox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

