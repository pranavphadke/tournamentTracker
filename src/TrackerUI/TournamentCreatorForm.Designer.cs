namespace TrackerUI
{
    partial class TournamentCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentCreatorForm));
            this.createEditTournamentsTabPanel = new System.Windows.Forms.TabControl();
            this.createTournament = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.createNewTournamentButton = new System.Windows.Forms.Button();
            this.tournamentDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.newTournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.newTournamentNameLabel = new System.Windows.Forms.Label();
            this.selectPrizesGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedPrizesLabel = new System.Windows.Forms.Label();
            this.removeSelectedPrizesButton = new System.Windows.Forms.Button();
            this.addSelectedPrizesButton = new System.Windows.Forms.Button();
            this.selectedPrizesListBox = new System.Windows.Forms.ListBox();
            this.selectablePrizesListBox = new System.Windows.Forms.ListBox();
            this.jumpToCreateNewPrizeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.selectTeamGroupBox = new System.Windows.Forms.GroupBox();
            this.selectedTeamsLabel = new System.Windows.Forms.Label();
            this.removeSelectedTeamsButton = new System.Windows.Forms.Button();
            this.addSelectedTeamsButton = new System.Windows.Forms.Button();
            this.selectedTeamsListBox = new System.Windows.Forms.ListBox();
            this.jumpToCreateNewTeamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectableTeamsListBox = new System.Windows.Forms.ListBox();
            this.editTournament = new System.Windows.Forms.TabPage();
            this.deleteTournamentButton = new System.Windows.Forms.Button();
            this.updateTournomentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatableTornamentFeeTextBox = new System.Windows.Forms.TextBox();
            this.updatableTornamentNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addSelectedPrizeToTournamentButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeFromTournamentButton = new System.Windows.Forms.Button();
            this.currentSelectedPrizesListBox = new System.Windows.Forms.ListBox();
            this.currentSelectablePrizesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addSelectedTeamsToTournamentButton = new System.Windows.Forms.Button();
            this.removeSelectedTeamsFromTournamentButton = new System.Windows.Forms.Button();
            this.currentSelectedTeamsListBox = new System.Windows.Forms.ListBox();
            this.currentSelectableTeamsListBox = new System.Windows.Forms.ListBox();
            this.updatePrizeInfoLabel = new System.Windows.Forms.Label();
            this.updatableTournamentsComboBox = new System.Windows.Forms.ComboBox();
            this.createEditTournamentsTabPanel.SuspendLayout();
            this.createTournament.SuspendLayout();
            this.tournamentDetailsGroupBox.SuspendLayout();
            this.selectPrizesGroupBox.SuspendLayout();
            this.selectTeamGroupBox.SuspendLayout();
            this.editTournament.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // createEditTournamentsTabPanel
            // 
            this.createEditTournamentsTabPanel.Controls.Add(this.createTournament);
            this.createEditTournamentsTabPanel.Controls.Add(this.editTournament);
            this.createEditTournamentsTabPanel.Location = new System.Drawing.Point(-3, -1);
            this.createEditTournamentsTabPanel.Name = "createEditTournamentsTabPanel";
            this.createEditTournamentsTabPanel.SelectedIndex = 0;
            this.createEditTournamentsTabPanel.Size = new System.Drawing.Size(540, 516);
            this.createEditTournamentsTabPanel.TabIndex = 21;
            this.createEditTournamentsTabPanel.SelectedIndexChanged += new System.EventHandler(this.createEditTournamentsTabPanel_SelectedIndexChanged);
            // 
            // createTournament
            // 
            this.createTournament.Controls.Add(this.label3);
            this.createTournament.Controls.Add(this.createNewTournamentButton);
            this.createTournament.Controls.Add(this.tournamentDetailsGroupBox);
            this.createTournament.Controls.Add(this.selectPrizesGroupBox);
            this.createTournament.Controls.Add(this.selectTeamGroupBox);
            this.createTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournament.Location = new System.Drawing.Point(4, 26);
            this.createTournament.Name = "createTournament";
            this.createTournament.Padding = new System.Windows.Forms.Padding(3);
            this.createTournament.Size = new System.Drawing.Size(532, 486);
            this.createTournament.TabIndex = 0;
            this.createTournament.Text = "Create";
            this.createTournament.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Creating new Tournament";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewTournamentButton
            // 
            this.createNewTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.createNewTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createNewTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewTournamentButton.Location = new System.Drawing.Point(134, 439);
            this.createNewTournamentButton.Name = "createNewTournamentButton";
            this.createNewTournamentButton.Size = new System.Drawing.Size(257, 40);
            this.createNewTournamentButton.TabIndex = 18;
            this.createNewTournamentButton.Text = "Create this tournament";
            this.createNewTournamentButton.UseVisualStyleBackColor = true;
            this.createNewTournamentButton.Click += new System.EventHandler(this.CreateNewTournamentButton_Click);
            // 
            // tournamentDetailsGroupBox
            // 
            this.tournamentDetailsGroupBox.Controls.Add(this.entryFeeTextBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.newTournamentNameTextBox);
            this.tournamentDetailsGroupBox.Controls.Add(this.entryFeeLabel);
            this.tournamentDetailsGroupBox.Controls.Add(this.newTournamentNameLabel);
            this.tournamentDetailsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tournamentDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tournamentDetailsGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentDetailsGroupBox.Location = new System.Drawing.Point(11, 359);
            this.tournamentDetailsGroupBox.Name = "tournamentDetailsGroupBox";
            this.tournamentDetailsGroupBox.Size = new System.Drawing.Size(510, 65);
            this.tournamentDetailsGroupBox.TabIndex = 17;
            this.tournamentDetailsGroupBox.TabStop = false;
            this.tournamentDetailsGroupBox.Text = "Tournament details";
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryFeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeTextBox.Location = new System.Drawing.Point(449, 25);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(51, 29);
            this.entryFeeTextBox.TabIndex = 13;
            this.entryFeeTextBox.Text = "0";
            this.entryFeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newTournamentNameTextBox
            // 
            this.newTournamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTournamentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTournamentNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newTournamentNameTextBox.Location = new System.Drawing.Point(63, 25);
            this.newTournamentNameTextBox.Name = "newTournamentNameTextBox";
            this.newTournamentNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.newTournamentNameTextBox.TabIndex = 12;
            this.newTournamentNameTextBox.Text = "Name of the tournament";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(359, 29);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(89, 21);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry fee : $";
            this.entryFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newTournamentNameLabel
            // 
            this.newTournamentNameLabel.AutoSize = true;
            this.newTournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newTournamentNameLabel.Location = new System.Drawing.Point(6, 29);
            this.newTournamentNameLabel.Name = "newTournamentNameLabel";
            this.newTournamentNameLabel.Size = new System.Drawing.Size(58, 21);
            this.newTournamentNameLabel.TabIndex = 9;
            this.newTournamentNameLabel.Text = "Name :";
            this.newTournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectPrizesGroupBox
            // 
            this.selectPrizesGroupBox.Controls.Add(this.selectedPrizesLabel);
            this.selectPrizesGroupBox.Controls.Add(this.removeSelectedPrizesButton);
            this.selectPrizesGroupBox.Controls.Add(this.addSelectedPrizesButton);
            this.selectPrizesGroupBox.Controls.Add(this.selectedPrizesListBox);
            this.selectPrizesGroupBox.Controls.Add(this.selectablePrizesListBox);
            this.selectPrizesGroupBox.Controls.Add(this.jumpToCreateNewPrizeButton);
            this.selectPrizesGroupBox.Controls.Add(this.label2);
            this.selectPrizesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPrizesGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectPrizesGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectPrizesGroupBox.Location = new System.Drawing.Point(11, 207);
            this.selectPrizesGroupBox.Name = "selectPrizesGroupBox";
            this.selectPrizesGroupBox.Size = new System.Drawing.Size(510, 137);
            this.selectPrizesGroupBox.TabIndex = 16;
            this.selectPrizesGroupBox.TabStop = false;
            this.selectPrizesGroupBox.Text = "Select prizes";
            // 
            // selectedPrizesLabel
            // 
            this.selectedPrizesLabel.AutoSize = true;
            this.selectedPrizesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedPrizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPrizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedPrizesLabel.Location = new System.Drawing.Point(348, 113);
            this.selectedPrizesLabel.Name = "selectedPrizesLabel";
            this.selectedPrizesLabel.Size = new System.Drawing.Size(91, 17);
            this.selectedPrizesLabel.TabIndex = 20;
            this.selectedPrizesLabel.Text = "Selected prizes";
            this.selectedPrizesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeSelectedPrizesButton
            // 
            this.removeSelectedPrizesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizesButton.Location = new System.Drawing.Point(245, 66);
            this.removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
            this.removeSelectedPrizesButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedPrizesButton.TabIndex = 19;
            this.removeSelectedPrizesButton.Text = "<";
            this.removeSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizesButton.Click += new System.EventHandler(this.RemoveSelectedPrizesButton_Click);
            // 
            // addSelectedPrizesButton
            // 
            this.addSelectedPrizesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedPrizesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedPrizesButton.Location = new System.Drawing.Point(245, 34);
            this.addSelectedPrizesButton.Name = "addSelectedPrizesButton";
            this.addSelectedPrizesButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedPrizesButton.TabIndex = 22;
            this.addSelectedPrizesButton.Text = ">";
            this.addSelectedPrizesButton.UseVisualStyleBackColor = true;
            this.addSelectedPrizesButton.Click += new System.EventHandler(this.AddSelectedPrizesButton_Click);
            // 
            // selectedPrizesListBox
            // 
            this.selectedPrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedPrizesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.selectedPrizesListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedPrizesListBox.FormattingEnabled = true;
            this.selectedPrizesListBox.ItemHeight = 17;
            this.selectedPrizesListBox.Location = new System.Drawing.Point(286, 23);
            this.selectedPrizesListBox.Name = "selectedPrizesListBox";
            this.selectedPrizesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedPrizesListBox.Size = new System.Drawing.Size(214, 87);
            this.selectedPrizesListBox.Sorted = true;
            this.selectedPrizesListBox.TabIndex = 21;
            // 
            // selectablePrizesListBox
            // 
            this.selectablePrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectablePrizesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.selectablePrizesListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectablePrizesListBox.FormattingEnabled = true;
            this.selectablePrizesListBox.ItemHeight = 17;
            this.selectablePrizesListBox.Location = new System.Drawing.Point(12, 29);
            this.selectablePrizesListBox.Name = "selectablePrizesListBox";
            this.selectablePrizesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectablePrizesListBox.Size = new System.Drawing.Size(214, 53);
            this.selectablePrizesListBox.Sorted = true;
            this.selectablePrizesListBox.TabIndex = 18;
            // 
            // jumpToCreateNewPrizeButton
            // 
            this.jumpToCreateNewPrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpToCreateNewPrizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpToCreateNewPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.jumpToCreateNewPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.jumpToCreateNewPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jumpToCreateNewPrizeButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpToCreateNewPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpToCreateNewPrizeButton.Location = new System.Drawing.Point(66, 104);
            this.jumpToCreateNewPrizeButton.Name = "jumpToCreateNewPrizeButton";
            this.jumpToCreateNewPrizeButton.Size = new System.Drawing.Size(107, 22);
            this.jumpToCreateNewPrizeButton.TabIndex = 19;
            this.jumpToCreateNewPrizeButton.Text = "Create a new prize";
            this.jumpToCreateNewPrizeButton.UseVisualStyleBackColor = true;
            this.jumpToCreateNewPrizeButton.Click += new System.EventHandler(this.JumpToCreateNewPrizeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(101, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "- or -";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectTeamGroupBox
            // 
            this.selectTeamGroupBox.Controls.Add(this.selectedTeamsLabel);
            this.selectTeamGroupBox.Controls.Add(this.removeSelectedTeamsButton);
            this.selectTeamGroupBox.Controls.Add(this.addSelectedTeamsButton);
            this.selectTeamGroupBox.Controls.Add(this.selectedTeamsListBox);
            this.selectTeamGroupBox.Controls.Add(this.jumpToCreateNewTeamButton);
            this.selectTeamGroupBox.Controls.Add(this.label1);
            this.selectTeamGroupBox.Controls.Add(this.selectableTeamsListBox);
            this.selectTeamGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTeamGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectTeamGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamGroupBox.Location = new System.Drawing.Point(11, 39);
            this.selectTeamGroupBox.Name = "selectTeamGroupBox";
            this.selectTeamGroupBox.Size = new System.Drawing.Size(510, 153);
            this.selectTeamGroupBox.TabIndex = 15;
            this.selectTeamGroupBox.TabStop = false;
            this.selectTeamGroupBox.Text = "Select teams";
            // 
            // selectedTeamsLabel
            // 
            this.selectedTeamsLabel.AutoSize = true;
            this.selectedTeamsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedTeamsLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTeamsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedTeamsLabel.Location = new System.Drawing.Point(347, 129);
            this.selectedTeamsLabel.Name = "selectedTeamsLabel";
            this.selectedTeamsLabel.Size = new System.Drawing.Size(92, 17);
            this.selectedTeamsLabel.TabIndex = 19;
            this.selectedTeamsLabel.Text = "Selected teams";
            this.selectedTeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeSelectedTeamsButton
            // 
            this.removeSelectedTeamsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedTeamsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedTeamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamsButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamsButton.Location = new System.Drawing.Point(245, 72);
            this.removeSelectedTeamsButton.Name = "removeSelectedTeamsButton";
            this.removeSelectedTeamsButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedTeamsButton.TabIndex = 18;
            this.removeSelectedTeamsButton.Text = "<";
            this.removeSelectedTeamsButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamsButton.Click += new System.EventHandler(this.RemoveSelectedTeamsButton_Click);
            // 
            // addSelectedTeamsButton
            // 
            this.addSelectedTeamsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedTeamsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedTeamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedTeamsButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedTeamsButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamsButton.Location = new System.Drawing.Point(245, 40);
            this.addSelectedTeamsButton.Name = "addSelectedTeamsButton";
            this.addSelectedTeamsButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedTeamsButton.TabIndex = 17;
            this.addSelectedTeamsButton.Text = ">";
            this.addSelectedTeamsButton.UseVisualStyleBackColor = true;
            this.addSelectedTeamsButton.Click += new System.EventHandler(this.AddSelectedTeamsButton_Click);
            // 
            // selectedTeamsListBox
            // 
            this.selectedTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.selectedTeamsListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedTeamsListBox.FormattingEnabled = true;
            this.selectedTeamsListBox.ItemHeight = 17;
            this.selectedTeamsListBox.Location = new System.Drawing.Point(286, 22);
            this.selectedTeamsListBox.Name = "selectedTeamsListBox";
            this.selectedTeamsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedTeamsListBox.Size = new System.Drawing.Size(214, 104);
            this.selectedTeamsListBox.Sorted = true;
            this.selectedTeamsListBox.TabIndex = 16;
            // 
            // jumpToCreateNewTeamButton
            // 
            this.jumpToCreateNewTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jumpToCreateNewTeamButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpToCreateNewTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.jumpToCreateNewTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.jumpToCreateNewTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jumpToCreateNewTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpToCreateNewTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.jumpToCreateNewTeamButton.Location = new System.Drawing.Point(66, 120);
            this.jumpToCreateNewTeamButton.Name = "jumpToCreateNewTeamButton";
            this.jumpToCreateNewTeamButton.Size = new System.Drawing.Size(107, 22);
            this.jumpToCreateNewTeamButton.TabIndex = 15;
            this.jumpToCreateNewTeamButton.Text = "Create a new team";
            this.jumpToCreateNewTeamButton.UseVisualStyleBackColor = true;
            this.jumpToCreateNewTeamButton.Click += new System.EventHandler(this.JumpToCreateNewTeamButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(101, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "- or -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectableTeamsListBox
            // 
            this.selectableTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectableTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.selectableTeamsListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectableTeamsListBox.FormattingEnabled = true;
            this.selectableTeamsListBox.ItemHeight = 17;
            this.selectableTeamsListBox.Location = new System.Drawing.Point(12, 28);
            this.selectableTeamsListBox.Name = "selectableTeamsListBox";
            this.selectableTeamsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectableTeamsListBox.Size = new System.Drawing.Size(214, 70);
            this.selectableTeamsListBox.Sorted = true;
            this.selectableTeamsListBox.TabIndex = 0;
            // 
            // editTournament
            // 
            this.editTournament.Controls.Add(this.deleteTournamentButton);
            this.editTournament.Controls.Add(this.updateTournomentButton);
            this.editTournament.Controls.Add(this.groupBox1);
            this.editTournament.Controls.Add(this.groupBox2);
            this.editTournament.Controls.Add(this.groupBox3);
            this.editTournament.Controls.Add(this.updatePrizeInfoLabel);
            this.editTournament.Controls.Add(this.updatableTournamentsComboBox);
            this.editTournament.Location = new System.Drawing.Point(4, 26);
            this.editTournament.Name = "editTournament";
            this.editTournament.Padding = new System.Windows.Forms.Padding(3);
            this.editTournament.Size = new System.Drawing.Size(532, 486);
            this.editTournament.TabIndex = 1;
            this.editTournament.Text = "Edit";
            this.editTournament.UseVisualStyleBackColor = true;
            // 
            // deleteTournamentButton
            // 
            this.deleteTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.deleteTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteTournamentButton.Location = new System.Drawing.Point(268, 434);
            this.deleteTournamentButton.Name = "deleteTournamentButton";
            this.deleteTournamentButton.Size = new System.Drawing.Size(257, 40);
            this.deleteTournamentButton.TabIndex = 37;
            this.deleteTournamentButton.Text = "Delete this tournament";
            this.deleteTournamentButton.UseVisualStyleBackColor = true;
            this.deleteTournamentButton.Click += new System.EventHandler(this.deleteTournamentButton_Click);
            // 
            // updateTournomentButton
            // 
            this.updateTournomentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTournomentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateTournomentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updateTournomentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateTournomentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTournomentButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTournomentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateTournomentButton.Location = new System.Drawing.Point(6, 434);
            this.updateTournomentButton.Name = "updateTournomentButton";
            this.updateTournomentButton.Size = new System.Drawing.Size(257, 40);
            this.updateTournomentButton.TabIndex = 36;
            this.updateTournomentButton.Text = "Update this tournament";
            this.updateTournomentButton.UseVisualStyleBackColor = true;
            this.updateTournomentButton.Click += new System.EventHandler(this.updateTournomentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatableTornamentFeeTextBox);
            this.groupBox1.Controls.Add(this.updatableTornamentNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 65);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tournament details";
            // 
            // updatableTornamentFeeTextBox
            // 
            this.updatableTornamentFeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatableTornamentFeeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTornamentFeeTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTornamentFeeTextBox.Location = new System.Drawing.Point(449, 25);
            this.updatableTornamentFeeTextBox.Name = "updatableTornamentFeeTextBox";
            this.updatableTornamentFeeTextBox.Size = new System.Drawing.Size(51, 29);
            this.updatableTornamentFeeTextBox.TabIndex = 13;
            this.updatableTornamentFeeTextBox.Text = "0";
            this.updatableTornamentFeeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updatableTornamentNameTextBox
            // 
            this.updatableTornamentNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatableTornamentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTornamentNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTornamentNameTextBox.Location = new System.Drawing.Point(63, 25);
            this.updatableTornamentNameTextBox.Name = "updatableTornamentNameTextBox";
            this.updatableTornamentNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.updatableTornamentNameTextBox.TabIndex = 12;
            this.updatableTornamentNameTextBox.Text = "Name of the tournament";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(359, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Entry fee : $";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.addSelectedPrizeToTournamentButton);
            this.groupBox2.Controls.Add(this.removeSelectedPrizeFromTournamentButton);
            this.groupBox2.Controls.Add(this.currentSelectedPrizesListBox);
            this.groupBox2.Controls.Add(this.currentSelectablePrizesListBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(11, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 137);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected prizes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(78, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Selected prizes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSelectedPrizeToTournamentButton
            // 
            this.addSelectedPrizeToTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedPrizeToTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedPrizeToTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedPrizeToTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedPrizeToTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedPrizeToTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedPrizeToTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedPrizeToTournamentButton.Location = new System.Drawing.Point(245, 66);
            this.addSelectedPrizeToTournamentButton.Name = "addSelectedPrizeToTournamentButton";
            this.addSelectedPrizeToTournamentButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedPrizeToTournamentButton.TabIndex = 19;
            this.addSelectedPrizeToTournamentButton.Text = "<";
            this.addSelectedPrizeToTournamentButton.UseVisualStyleBackColor = true;
            this.addSelectedPrizeToTournamentButton.Click += new System.EventHandler(this.addSelectedPrizeToTournamentButton_Click);
            // 
            // removeSelectedPrizeFromTournamentButton
            // 
            this.removeSelectedPrizeFromTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedPrizeFromTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizeFromTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedPrizeFromTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedPrizeFromTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeFromTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedPrizeFromTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedPrizeFromTournamentButton.Location = new System.Drawing.Point(245, 34);
            this.removeSelectedPrizeFromTournamentButton.Name = "removeSelectedPrizeFromTournamentButton";
            this.removeSelectedPrizeFromTournamentButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedPrizeFromTournamentButton.TabIndex = 22;
            this.removeSelectedPrizeFromTournamentButton.Text = ">";
            this.removeSelectedPrizeFromTournamentButton.UseVisualStyleBackColor = true;
            this.removeSelectedPrizeFromTournamentButton.Click += new System.EventHandler(this.removeSelectedPrizeFromTournamentButton_Click);
            // 
            // currentSelectedPrizesListBox
            // 
            this.currentSelectedPrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectedPrizesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentSelectedPrizesListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectedPrizesListBox.FormattingEnabled = true;
            this.currentSelectedPrizesListBox.ItemHeight = 17;
            this.currentSelectedPrizesListBox.Location = new System.Drawing.Point(16, 23);
            this.currentSelectedPrizesListBox.Name = "currentSelectedPrizesListBox";
            this.currentSelectedPrizesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectedPrizesListBox.Size = new System.Drawing.Size(214, 87);
            this.currentSelectedPrizesListBox.Sorted = true;
            this.currentSelectedPrizesListBox.TabIndex = 21;
            // 
            // currentSelectablePrizesListBox
            // 
            this.currentSelectablePrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectablePrizesListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.currentSelectablePrizesListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectablePrizesListBox.FormattingEnabled = true;
            this.currentSelectablePrizesListBox.ItemHeight = 17;
            this.currentSelectablePrizesListBox.Location = new System.Drawing.Point(281, 23);
            this.currentSelectablePrizesListBox.Name = "currentSelectablePrizesListBox";
            this.currentSelectablePrizesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectablePrizesListBox.Size = new System.Drawing.Size(214, 87);
            this.currentSelectablePrizesListBox.Sorted = true;
            this.currentSelectablePrizesListBox.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addSelectedTeamsToTournamentButton);
            this.groupBox3.Controls.Add(this.removeSelectedTeamsFromTournamentButton);
            this.groupBox3.Controls.Add(this.currentSelectedTeamsListBox);
            this.groupBox3.Controls.Add(this.currentSelectableTeamsListBox);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(11, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 153);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected teams";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(77, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Selected teams";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSelectedTeamsToTournamentButton
            // 
            this.addSelectedTeamsToTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedTeamsToTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamsToTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedTeamsToTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedTeamsToTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedTeamsToTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedTeamsToTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamsToTournamentButton.Location = new System.Drawing.Point(245, 72);
            this.addSelectedTeamsToTournamentButton.Name = "addSelectedTeamsToTournamentButton";
            this.addSelectedTeamsToTournamentButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedTeamsToTournamentButton.TabIndex = 18;
            this.addSelectedTeamsToTournamentButton.Text = "<";
            this.addSelectedTeamsToTournamentButton.UseVisualStyleBackColor = true;
            this.addSelectedTeamsToTournamentButton.Click += new System.EventHandler(this.addSelectedTeamsToTournamentButton_Click);
            // 
            // removeSelectedTeamsFromTournamentButton
            // 
            this.removeSelectedTeamsFromTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedTeamsFromTournamentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamsFromTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedTeamsFromTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedTeamsFromTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamsFromTournamentButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamsFromTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamsFromTournamentButton.Location = new System.Drawing.Point(245, 40);
            this.removeSelectedTeamsFromTournamentButton.Name = "removeSelectedTeamsFromTournamentButton";
            this.removeSelectedTeamsFromTournamentButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedTeamsFromTournamentButton.TabIndex = 17;
            this.removeSelectedTeamsFromTournamentButton.Text = ">";
            this.removeSelectedTeamsFromTournamentButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamsFromTournamentButton.Click += new System.EventHandler(this.removeSelectedTeamsFromTournamentButton_Click);
            // 
            // currentSelectedTeamsListBox
            // 
            this.currentSelectedTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectedTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentSelectedTeamsListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectedTeamsListBox.FormattingEnabled = true;
            this.currentSelectedTeamsListBox.ItemHeight = 17;
            this.currentSelectedTeamsListBox.Location = new System.Drawing.Point(16, 22);
            this.currentSelectedTeamsListBox.Name = "currentSelectedTeamsListBox";
            this.currentSelectedTeamsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectedTeamsListBox.Size = new System.Drawing.Size(214, 104);
            this.currentSelectedTeamsListBox.Sorted = true;
            this.currentSelectedTeamsListBox.TabIndex = 16;
            // 
            // currentSelectableTeamsListBox
            // 
            this.currentSelectableTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectableTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.currentSelectableTeamsListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectableTeamsListBox.FormattingEnabled = true;
            this.currentSelectableTeamsListBox.ItemHeight = 17;
            this.currentSelectableTeamsListBox.Location = new System.Drawing.Point(281, 23);
            this.currentSelectableTeamsListBox.Name = "currentSelectableTeamsListBox";
            this.currentSelectableTeamsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectableTeamsListBox.Size = new System.Drawing.Size(214, 104);
            this.currentSelectableTeamsListBox.Sorted = true;
            this.currentSelectableTeamsListBox.TabIndex = 0;
            // 
            // updatePrizeInfoLabel
            // 
            this.updatePrizeInfoLabel.AutoSize = true;
            this.updatePrizeInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeInfoLabel.Location = new System.Drawing.Point(19, 11);
            this.updatePrizeInfoLabel.Name = "updatePrizeInfoLabel";
            this.updatePrizeInfoLabel.Size = new System.Drawing.Size(177, 25);
            this.updatePrizeInfoLabel.TabIndex = 32;
            this.updatePrizeInfoLabel.Text = "Editing Tournament :";
            this.updatePrizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatableTournamentsComboBox
            // 
            this.updatableTournamentsComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatableTournamentsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updatableTournamentsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatableTournamentsComboBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTournamentsComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTournamentsComboBox.FormattingEnabled = true;
            this.updatableTournamentsComboBox.Location = new System.Drawing.Point(192, 9);
            this.updatableTournamentsComboBox.Name = "updatableTournamentsComboBox";
            this.updatableTournamentsComboBox.Size = new System.Drawing.Size(302, 29);
            this.updatableTournamentsComboBox.TabIndex = 31;
            this.updatableTournamentsComboBox.SelectedIndexChanged += new System.EventHandler(this.updatableTournamentsComboBox_SelectedIndexChanged);
            // 
            // TournamentCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.createEditTournamentsTabPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "TournamentCreatorForm";
            this.Text = "Tournament Creator";
            this.createEditTournamentsTabPanel.ResumeLayout(false);
            this.createTournament.ResumeLayout(false);
            this.createTournament.PerformLayout();
            this.tournamentDetailsGroupBox.ResumeLayout(false);
            this.tournamentDetailsGroupBox.PerformLayout();
            this.selectPrizesGroupBox.ResumeLayout(false);
            this.selectPrizesGroupBox.PerformLayout();
            this.selectTeamGroupBox.ResumeLayout(false);
            this.selectTeamGroupBox.PerformLayout();
            this.editTournament.ResumeLayout(false);
            this.editTournament.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl createEditTournamentsTabPanel;
        private System.Windows.Forms.TabPage createTournament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createNewTournamentButton;
        private System.Windows.Forms.GroupBox tournamentDetailsGroupBox;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.TextBox newTournamentNameTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.Label newTournamentNameLabel;
        private System.Windows.Forms.GroupBox selectPrizesGroupBox;
        private System.Windows.Forms.Label selectedPrizesLabel;
        private System.Windows.Forms.Button removeSelectedPrizesButton;
        private System.Windows.Forms.Button addSelectedPrizesButton;
        private System.Windows.Forms.ListBox selectedPrizesListBox;
        private System.Windows.Forms.ListBox selectablePrizesListBox;
        private System.Windows.Forms.Button jumpToCreateNewPrizeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox selectTeamGroupBox;
        private System.Windows.Forms.Label selectedTeamsLabel;
        private System.Windows.Forms.Button removeSelectedTeamsButton;
        private System.Windows.Forms.Button addSelectedTeamsButton;
        private System.Windows.Forms.ListBox selectedTeamsListBox;
        private System.Windows.Forms.Button jumpToCreateNewTeamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox selectableTeamsListBox;
        private System.Windows.Forms.TabPage editTournament;
        private System.Windows.Forms.Label updatePrizeInfoLabel;
        private System.Windows.Forms.ComboBox updatableTournamentsComboBox;
        private System.Windows.Forms.Button updateTournomentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox updatableTornamentFeeTextBox;
        private System.Windows.Forms.TextBox updatableTornamentNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addSelectedPrizeToTournamentButton;
        private System.Windows.Forms.Button removeSelectedPrizeFromTournamentButton;
        private System.Windows.Forms.ListBox currentSelectedPrizesListBox;
        private System.Windows.Forms.ListBox currentSelectablePrizesListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addSelectedTeamsToTournamentButton;
        private System.Windows.Forms.Button removeSelectedTeamsFromTournamentButton;
        private System.Windows.Forms.ListBox currentSelectedTeamsListBox;
        private System.Windows.Forms.ListBox currentSelectableTeamsListBox;
        private System.Windows.Forms.Button deleteTournamentButton;
    }
}