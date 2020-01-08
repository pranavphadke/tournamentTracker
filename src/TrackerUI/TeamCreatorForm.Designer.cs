namespace TrackerUI
{
    partial class TeamCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamCreatorForm));
            this.createEditTeamsTabPanel = new System.Windows.Forms.TabControl();
            this.createTeam = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.createNewTeamButton = new System.Windows.Forms.Button();
            this.selectTeamMembersGroupBox = new System.Windows.Forms.GroupBox();
            this.addEditMembersTabPanel = new System.Windows.Forms.TabControl();
            this.addMember = new System.Windows.Forms.TabPage();
            this.addNewMemberInfoLabel = new System.Windows.Forms.Label();
            this.addNewMemberButton = new System.Windows.Forms.Button();
            this.newMemberPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.newMemberPhoneLabel = new System.Windows.Forms.Label();
            this.newMemberEmailTextBox = new System.Windows.Forms.TextBox();
            this.newMemberEmailLabel = new System.Windows.Forms.Label();
            this.newMemberLastNameTextBox = new System.Windows.Forms.TextBox();
            this.newMemberMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.newMemberFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.newMemberNameLabel = new System.Windows.Forms.Label();
            this.editMember = new System.Windows.Forms.TabPage();
            this.deleteMemberInfoButton = new System.Windows.Forms.Button();
            this.updateMemberInfoLabel = new System.Windows.Forms.Label();
            this.updatableTeamMembersComboBox = new System.Windows.Forms.ComboBox();
            this.updateMemberInfoButton = new System.Windows.Forms.Button();
            this.updateMemberPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberPhoneNumberLabel = new System.Windows.Forms.Label();
            this.updateMemberEmailTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberEmailLabel = new System.Windows.Forms.Label();
            this.updateMemberLastNameTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberNameLabel = new System.Windows.Forms.Label();
            this.selectedTeamsLabel = new System.Windows.Forms.Label();
            this.removeSelectedTeamMembersButton = new System.Windows.Forms.Button();
            this.addSelectedTeamMembersButton = new System.Windows.Forms.Button();
            this.selectedTeamMembersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectableTeamMembersListBox = new System.Windows.Forms.ListBox();
            this.teamDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.newTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.newTeamNameLabel = new System.Windows.Forms.Label();
            this.editTeam = new System.Windows.Forms.TabPage();
            this.updateTeamInfoButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addSelectedTeamMemberToTeamButton = new System.Windows.Forms.Button();
            this.removeSelectedTeamMemberFromTeamButton = new System.Windows.Forms.Button();
            this.currentSelectedTeamMembersListBox = new System.Windows.Forms.ListBox();
            this.currentSelectableTeamMembersListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updatableTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.updatePrizeInfoLabel = new System.Windows.Forms.Label();
            this.updatableTeamComboBox = new System.Windows.Forms.ComboBox();
            this.deleteTeamInfoButton = new System.Windows.Forms.Button();
            this.createEditTeamsTabPanel.SuspendLayout();
            this.createTeam.SuspendLayout();
            this.selectTeamMembersGroupBox.SuspendLayout();
            this.addEditMembersTabPanel.SuspendLayout();
            this.addMember.SuspendLayout();
            this.editMember.SuspendLayout();
            this.teamDetailsGroupBox.SuspendLayout();
            this.editTeam.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createEditTeamsTabPanel
            // 
            this.createEditTeamsTabPanel.Controls.Add(this.createTeam);
            this.createEditTeamsTabPanel.Controls.Add(this.editTeam);
            this.createEditTeamsTabPanel.Location = new System.Drawing.Point(-3, -1);
            this.createEditTeamsTabPanel.Name = "createEditTeamsTabPanel";
            this.createEditTeamsTabPanel.SelectedIndex = 0;
            this.createEditTeamsTabPanel.Size = new System.Drawing.Size(540, 516);
            this.createEditTeamsTabPanel.TabIndex = 22;
            this.createEditTeamsTabPanel.SelectedIndexChanged += new System.EventHandler(this.CreateEditTeamsTabPanel_SelectedIndexChanged);
            // 
            // createTeam
            // 
            this.createTeam.Controls.Add(this.label13);
            this.createTeam.Controls.Add(this.createNewTeamButton);
            this.createTeam.Controls.Add(this.selectTeamMembersGroupBox);
            this.createTeam.Controls.Add(this.teamDetailsGroupBox);
            this.createTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTeam.Location = new System.Drawing.Point(4, 26);
            this.createTeam.Name = "createTeam";
            this.createTeam.Padding = new System.Windows.Forms.Padding(3);
            this.createTeam.Size = new System.Drawing.Size(532, 486);
            this.createTeam.TabIndex = 0;
            this.createTeam.Text = "Create";
            this.createTeam.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(19, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Creating new Team";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewTeamButton
            // 
            this.createNewTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewTeamButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.createNewTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createNewTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewTeamButton.Location = new System.Drawing.Point(172, 439);
            this.createNewTeamButton.Name = "createNewTeamButton";
            this.createNewTeamButton.Size = new System.Drawing.Size(188, 40);
            this.createNewTeamButton.TabIndex = 24;
            this.createNewTeamButton.Text = "Create this team";
            this.createNewTeamButton.UseVisualStyleBackColor = true;
            this.createNewTeamButton.Click += new System.EventHandler(this.CreateNewTeamButton_Click);
            // 
            // selectTeamMembersGroupBox
            // 
            this.selectTeamMembersGroupBox.Controls.Add(this.addEditMembersTabPanel);
            this.selectTeamMembersGroupBox.Controls.Add(this.selectedTeamsLabel);
            this.selectTeamMembersGroupBox.Controls.Add(this.removeSelectedTeamMembersButton);
            this.selectTeamMembersGroupBox.Controls.Add(this.addSelectedTeamMembersButton);
            this.selectTeamMembersGroupBox.Controls.Add(this.selectedTeamMembersListBox);
            this.selectTeamMembersGroupBox.Controls.Add(this.label1);
            this.selectTeamMembersGroupBox.Controls.Add(this.selectableTeamMembersListBox);
            this.selectTeamMembersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectTeamMembersGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectTeamMembersGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamMembersGroupBox.Location = new System.Drawing.Point(11, 37);
            this.selectTeamMembersGroupBox.Name = "selectTeamMembersGroupBox";
            this.selectTeamMembersGroupBox.Size = new System.Drawing.Size(510, 316);
            this.selectTeamMembersGroupBox.TabIndex = 22;
            this.selectTeamMembersGroupBox.TabStop = false;
            this.selectTeamMembersGroupBox.Text = "Select team members";
            // 
            // addEditMembersTabPanel
            // 
            this.addEditMembersTabPanel.Controls.Add(this.addMember);
            this.addEditMembersTabPanel.Controls.Add(this.editMember);
            this.addEditMembersTabPanel.Location = new System.Drawing.Point(12, 128);
            this.addEditMembersTabPanel.Name = "addEditMembersTabPanel";
            this.addEditMembersTabPanel.SelectedIndex = 0;
            this.addEditMembersTabPanel.Size = new System.Drawing.Size(488, 182);
            this.addEditMembersTabPanel.TabIndex = 20;
            this.addEditMembersTabPanel.SelectedIndexChanged += new System.EventHandler(this.AddEditMembersTabPanel_SelectedIndexChanged);
            // 
            // addMember
            // 
            this.addMember.Controls.Add(this.addNewMemberInfoLabel);
            this.addMember.Controls.Add(this.addNewMemberButton);
            this.addMember.Controls.Add(this.newMemberPhoneNumberTextBox);
            this.addMember.Controls.Add(this.newMemberPhoneLabel);
            this.addMember.Controls.Add(this.newMemberEmailTextBox);
            this.addMember.Controls.Add(this.newMemberEmailLabel);
            this.addMember.Controls.Add(this.newMemberLastNameTextBox);
            this.addMember.Controls.Add(this.newMemberMiddleNameTextBox);
            this.addMember.Controls.Add(this.newMemberFirstNameTextBox);
            this.addMember.Controls.Add(this.newMemberNameLabel);
            this.addMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addMember.Location = new System.Drawing.Point(4, 30);
            this.addMember.Name = "addMember";
            this.addMember.Padding = new System.Windows.Forms.Padding(3);
            this.addMember.Size = new System.Drawing.Size(480, 148);
            this.addMember.TabIndex = 0;
            this.addMember.Text = "Add";
            this.addMember.UseVisualStyleBackColor = true;
            // 
            // addNewMemberInfoLabel
            // 
            this.addNewMemberInfoLabel.AutoSize = true;
            this.addNewMemberInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewMemberInfoLabel.Location = new System.Drawing.Point(19, 11);
            this.addNewMemberInfoLabel.Name = "addNewMemberInfoLabel";
            this.addNewMemberInfoLabel.Size = new System.Drawing.Size(183, 25);
            this.addNewMemberInfoLabel.TabIndex = 22;
            this.addNewMemberInfoLabel.Text = "Adding new member";
            this.addNewMemberInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addNewMemberButton
            // 
            this.addNewMemberButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewMemberButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addNewMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addNewMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewMemberButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewMemberButton.Location = new System.Drawing.Point(191, 120);
            this.addNewMemberButton.Name = "addNewMemberButton";
            this.addNewMemberButton.Size = new System.Drawing.Size(107, 22);
            this.addNewMemberButton.TabIndex = 21;
            this.addNewMemberButton.Text = "Add new member";
            this.addNewMemberButton.UseVisualStyleBackColor = true;
            this.addNewMemberButton.Click += new System.EventHandler(this.AddNewMemberButton_Click);
            // 
            // newMemberPhoneNumberTextBox
            // 
            this.newMemberPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberPhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberPhoneNumberTextBox.Location = new System.Drawing.Point(351, 83);
            this.newMemberPhoneNumberTextBox.Name = "newMemberPhoneNumberTextBox";
            this.newMemberPhoneNumberTextBox.Size = new System.Drawing.Size(111, 29);
            this.newMemberPhoneNumberTextBox.TabIndex = 20;
            this.newMemberPhoneNumberTextBox.Text = "xxxyyyzzzz";
            this.newMemberPhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newMemberPhoneLabel
            // 
            this.newMemberPhoneLabel.AutoSize = true;
            this.newMemberPhoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberPhoneLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberPhoneLabel.Location = new System.Drawing.Point(291, 87);
            this.newMemberPhoneLabel.Name = "newMemberPhoneLabel";
            this.newMemberPhoneLabel.Size = new System.Drawing.Size(62, 21);
            this.newMemberPhoneLabel.TabIndex = 19;
            this.newMemberPhoneLabel.Text = "Phone :";
            this.newMemberPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newMemberEmailTextBox
            // 
            this.newMemberEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberEmailTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberEmailTextBox.Location = new System.Drawing.Point(79, 83);
            this.newMemberEmailTextBox.Name = "newMemberEmailTextBox";
            this.newMemberEmailTextBox.Size = new System.Drawing.Size(206, 29);
            this.newMemberEmailTextBox.TabIndex = 18;
            this.newMemberEmailTextBox.Text = "E-mail address";
            // 
            // newMemberEmailLabel
            // 
            this.newMemberEmailLabel.AutoSize = true;
            this.newMemberEmailLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberEmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberEmailLabel.Location = new System.Drawing.Point(19, 87);
            this.newMemberEmailLabel.Name = "newMemberEmailLabel";
            this.newMemberEmailLabel.Size = new System.Drawing.Size(59, 21);
            this.newMemberEmailLabel.TabIndex = 17;
            this.newMemberEmailLabel.Text = "E-mail :";
            this.newMemberEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newMemberLastNameTextBox
            // 
            this.newMemberLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberLastNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberLastNameTextBox.Location = new System.Drawing.Point(342, 47);
            this.newMemberLastNameTextBox.Name = "newMemberLastNameTextBox";
            this.newMemberLastNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.newMemberLastNameTextBox.TabIndex = 16;
            this.newMemberLastNameTextBox.Text = "Last name";
            this.newMemberLastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newMemberMiddleNameTextBox
            // 
            this.newMemberMiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberMiddleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberMiddleNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberMiddleNameTextBox.Location = new System.Drawing.Point(211, 47);
            this.newMemberMiddleNameTextBox.Name = "newMemberMiddleNameTextBox";
            this.newMemberMiddleNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.newMemberMiddleNameTextBox.TabIndex = 15;
            this.newMemberMiddleNameTextBox.Text = "Middle name";
            this.newMemberMiddleNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newMemberFirstNameTextBox
            // 
            this.newMemberFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newMemberFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberFirstNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberFirstNameTextBox.Location = new System.Drawing.Point(79, 47);
            this.newMemberFirstNameTextBox.Name = "newMemberFirstNameTextBox";
            this.newMemberFirstNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.newMemberFirstNameTextBox.TabIndex = 14;
            this.newMemberFirstNameTextBox.Text = "First name";
            this.newMemberFirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newMemberNameLabel
            // 
            this.newMemberNameLabel.AutoSize = true;
            this.newMemberNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newMemberNameLabel.Location = new System.Drawing.Point(19, 51);
            this.newMemberNameLabel.Name = "newMemberNameLabel";
            this.newMemberNameLabel.Size = new System.Drawing.Size(58, 21);
            this.newMemberNameLabel.TabIndex = 13;
            this.newMemberNameLabel.Text = "Name :";
            this.newMemberNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editMember
            // 
            this.editMember.Controls.Add(this.deleteMemberInfoButton);
            this.editMember.Controls.Add(this.updateMemberInfoLabel);
            this.editMember.Controls.Add(this.updatableTeamMembersComboBox);
            this.editMember.Controls.Add(this.updateMemberInfoButton);
            this.editMember.Controls.Add(this.updateMemberPhoneNumberTextBox);
            this.editMember.Controls.Add(this.updateMemberPhoneNumberLabel);
            this.editMember.Controls.Add(this.updateMemberEmailTextBox);
            this.editMember.Controls.Add(this.updateMemberEmailLabel);
            this.editMember.Controls.Add(this.updateMemberLastNameTextBox);
            this.editMember.Controls.Add(this.updateMemberMiddleNameTextBox);
            this.editMember.Controls.Add(this.updateMemberFirstNameTextBox);
            this.editMember.Controls.Add(this.updateMemberNameLabel);
            this.editMember.Location = new System.Drawing.Point(4, 30);
            this.editMember.Name = "editMember";
            this.editMember.Padding = new System.Windows.Forms.Padding(3);
            this.editMember.Size = new System.Drawing.Size(480, 148);
            this.editMember.TabIndex = 1;
            this.editMember.Text = "Edit";
            this.editMember.UseVisualStyleBackColor = true;
            // 
            // deleteMemberInfoButton
            // 
            this.deleteMemberInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteMemberInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteMemberInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.deleteMemberInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteMemberInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMemberInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteMemberInfoButton.Location = new System.Drawing.Point(250, 119);
            this.deleteMemberInfoButton.Name = "deleteMemberInfoButton";
            this.deleteMemberInfoButton.Size = new System.Drawing.Size(155, 22);
            this.deleteMemberInfoButton.TabIndex = 33;
            this.deleteMemberInfoButton.Text = "Delete member information";
            this.deleteMemberInfoButton.UseVisualStyleBackColor = true;
            this.deleteMemberInfoButton.Click += new System.EventHandler(this.DeleteMemberInfoButton_Click);
            // 
            // updateMemberInfoLabel
            // 
            this.updateMemberInfoLabel.AutoSize = true;
            this.updateMemberInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberInfoLabel.Location = new System.Drawing.Point(19, 11);
            this.updateMemberInfoLabel.Name = "updateMemberInfoLabel";
            this.updateMemberInfoLabel.Size = new System.Drawing.Size(201, 25);
            this.updateMemberInfoLabel.TabIndex = 32;
            this.updateMemberInfoLabel.Text = "Editing information for :";
            this.updateMemberInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatableTeamMembersComboBox
            // 
            this.updatableTeamMembersComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatableTeamMembersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updatableTeamMembersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatableTeamMembersComboBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTeamMembersComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTeamMembersComboBox.FormattingEnabled = true;
            this.updatableTeamMembersComboBox.Location = new System.Drawing.Point(227, 9);
            this.updatableTeamMembersComboBox.Name = "updatableTeamMembersComboBox";
            this.updatableTeamMembersComboBox.Size = new System.Drawing.Size(235, 29);
            this.updatableTeamMembersComboBox.TabIndex = 31;
            this.updatableTeamMembersComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdatableTeamMembersComboBox_SelectedIndexChanged);
            // 
            // updateMemberInfoButton
            // 
            this.updateMemberInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateMemberInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updateMemberInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateMemberInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMemberInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberInfoButton.Location = new System.Drawing.Point(79, 119);
            this.updateMemberInfoButton.Name = "updateMemberInfoButton";
            this.updateMemberInfoButton.Size = new System.Drawing.Size(155, 22);
            this.updateMemberInfoButton.TabIndex = 30;
            this.updateMemberInfoButton.Text = "Update member information";
            this.updateMemberInfoButton.UseVisualStyleBackColor = true;
            this.updateMemberInfoButton.Click += new System.EventHandler(this.UpdateMemberInfoButton_Click);
            // 
            // updateMemberPhoneNumberTextBox
            // 
            this.updateMemberPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateMemberPhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberPhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberPhoneNumberTextBox.Location = new System.Drawing.Point(351, 83);
            this.updateMemberPhoneNumberTextBox.Name = "updateMemberPhoneNumberTextBox";
            this.updateMemberPhoneNumberTextBox.Size = new System.Drawing.Size(111, 29);
            this.updateMemberPhoneNumberTextBox.TabIndex = 29;
            this.updateMemberPhoneNumberTextBox.Text = "xxxyyyzzzz";
            this.updateMemberPhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateMemberPhoneNumberLabel
            // 
            this.updateMemberPhoneNumberLabel.AutoSize = true;
            this.updateMemberPhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberPhoneNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberPhoneNumberLabel.Location = new System.Drawing.Point(291, 87);
            this.updateMemberPhoneNumberLabel.Name = "updateMemberPhoneNumberLabel";
            this.updateMemberPhoneNumberLabel.Size = new System.Drawing.Size(62, 21);
            this.updateMemberPhoneNumberLabel.TabIndex = 28;
            this.updateMemberPhoneNumberLabel.Text = "Phone :";
            this.updateMemberPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateMemberEmailTextBox
            // 
            this.updateMemberEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateMemberEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberEmailTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberEmailTextBox.Location = new System.Drawing.Point(79, 83);
            this.updateMemberEmailTextBox.Name = "updateMemberEmailTextBox";
            this.updateMemberEmailTextBox.Size = new System.Drawing.Size(206, 29);
            this.updateMemberEmailTextBox.TabIndex = 27;
            this.updateMemberEmailTextBox.Text = "E-mail address";
            // 
            // updateMemberEmailLabel
            // 
            this.updateMemberEmailLabel.AutoSize = true;
            this.updateMemberEmailLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberEmailLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberEmailLabel.Location = new System.Drawing.Point(19, 87);
            this.updateMemberEmailLabel.Name = "updateMemberEmailLabel";
            this.updateMemberEmailLabel.Size = new System.Drawing.Size(59, 21);
            this.updateMemberEmailLabel.TabIndex = 26;
            this.updateMemberEmailLabel.Text = "E-mail :";
            this.updateMemberEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateMemberLastNameTextBox
            // 
            this.updateMemberLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateMemberLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberLastNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberLastNameTextBox.Location = new System.Drawing.Point(342, 47);
            this.updateMemberLastNameTextBox.Name = "updateMemberLastNameTextBox";
            this.updateMemberLastNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.updateMemberLastNameTextBox.TabIndex = 25;
            this.updateMemberLastNameTextBox.Text = "Last name";
            this.updateMemberLastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateMemberMiddleNameTextBox
            // 
            this.updateMemberMiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateMemberMiddleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberMiddleNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberMiddleNameTextBox.Location = new System.Drawing.Point(211, 47);
            this.updateMemberMiddleNameTextBox.Name = "updateMemberMiddleNameTextBox";
            this.updateMemberMiddleNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.updateMemberMiddleNameTextBox.TabIndex = 24;
            this.updateMemberMiddleNameTextBox.Text = "Middle name";
            this.updateMemberMiddleNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateMemberFirstNameTextBox
            // 
            this.updateMemberFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateMemberFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberFirstNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberFirstNameTextBox.Location = new System.Drawing.Point(79, 47);
            this.updateMemberFirstNameTextBox.Name = "updateMemberFirstNameTextBox";
            this.updateMemberFirstNameTextBox.Size = new System.Drawing.Size(120, 29);
            this.updateMemberFirstNameTextBox.TabIndex = 23;
            this.updateMemberFirstNameTextBox.Text = "First name";
            this.updateMemberFirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateMemberNameLabel
            // 
            this.updateMemberNameLabel.AutoSize = true;
            this.updateMemberNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateMemberNameLabel.Location = new System.Drawing.Point(19, 51);
            this.updateMemberNameLabel.Name = "updateMemberNameLabel";
            this.updateMemberNameLabel.Size = new System.Drawing.Size(58, 21);
            this.updateMemberNameLabel.TabIndex = 22;
            this.updateMemberNameLabel.Text = "Name :";
            this.updateMemberNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedTeamsLabel
            // 
            this.selectedTeamsLabel.AutoSize = true;
            this.selectedTeamsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedTeamsLabel.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTeamsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedTeamsLabel.Location = new System.Drawing.Point(324, 112);
            this.selectedTeamsLabel.Name = "selectedTeamsLabel";
            this.selectedTeamsLabel.Size = new System.Drawing.Size(143, 17);
            this.selectedTeamsLabel.TabIndex = 19;
            this.selectedTeamsLabel.Text = "Selected team members";
            this.selectedTeamsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeSelectedTeamMembersButton
            // 
            this.removeSelectedTeamMembersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedTeamMembersButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedTeamMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedTeamMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamMembersButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamMembersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamMembersButton.Location = new System.Drawing.Point(245, 72);
            this.removeSelectedTeamMembersButton.Name = "removeSelectedTeamMembersButton";
            this.removeSelectedTeamMembersButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedTeamMembersButton.TabIndex = 18;
            this.removeSelectedTeamMembersButton.Text = "<";
            this.removeSelectedTeamMembersButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamMembersButton.Click += new System.EventHandler(this.RemoveSelectedTeamMembersButton_Click);
            // 
            // addSelectedTeamMembersButton
            // 
            this.addSelectedTeamMembersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedTeamMembersButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedTeamMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedTeamMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedTeamMembersButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedTeamMembersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamMembersButton.Location = new System.Drawing.Point(245, 40);
            this.addSelectedTeamMembersButton.Name = "addSelectedTeamMembersButton";
            this.addSelectedTeamMembersButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedTeamMembersButton.TabIndex = 17;
            this.addSelectedTeamMembersButton.Text = ">";
            this.addSelectedTeamMembersButton.UseVisualStyleBackColor = true;
            this.addSelectedTeamMembersButton.Click += new System.EventHandler(this.AddSelectedTeamMembersButton_Click);
            // 
            // selectedTeamMembersListBox
            // 
            this.selectedTeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedTeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.selectedTeamMembersListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectedTeamMembersListBox.FormattingEnabled = true;
            this.selectedTeamMembersListBox.ItemHeight = 17;
            this.selectedTeamMembersListBox.Location = new System.Drawing.Point(286, 22);
            this.selectedTeamMembersListBox.Name = "selectedTeamMembersListBox";
            this.selectedTeamMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectedTeamMembersListBox.Size = new System.Drawing.Size(214, 87);
            this.selectedTeamMembersListBox.Sorted = true;
            this.selectedTeamMembersListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(101, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "- or -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectableTeamMembersListBox
            // 
            this.selectableTeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectableTeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.selectableTeamMembersListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectableTeamMembersListBox.FormattingEnabled = true;
            this.selectableTeamMembersListBox.ItemHeight = 17;
            this.selectableTeamMembersListBox.Location = new System.Drawing.Point(12, 28);
            this.selectableTeamMembersListBox.Name = "selectableTeamMembersListBox";
            this.selectableTeamMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.selectableTeamMembersListBox.Size = new System.Drawing.Size(214, 70);
            this.selectableTeamMembersListBox.Sorted = true;
            this.selectableTeamMembersListBox.TabIndex = 0;
            // 
            // teamDetailsGroupBox
            // 
            this.teamDetailsGroupBox.Controls.Add(this.newTeamNameTextBox);
            this.teamDetailsGroupBox.Controls.Add(this.newTeamNameLabel);
            this.teamDetailsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamDetailsGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teamDetailsGroupBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.teamDetailsGroupBox.Location = new System.Drawing.Point(11, 359);
            this.teamDetailsGroupBox.Name = "teamDetailsGroupBox";
            this.teamDetailsGroupBox.Size = new System.Drawing.Size(510, 65);
            this.teamDetailsGroupBox.TabIndex = 23;
            this.teamDetailsGroupBox.TabStop = false;
            this.teamDetailsGroupBox.Text = "Team details";
            // 
            // newTeamNameTextBox
            // 
            this.newTeamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTeamNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTeamNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newTeamNameTextBox.Location = new System.Drawing.Point(63, 25);
            this.newTeamNameTextBox.Name = "newTeamNameTextBox";
            this.newTeamNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.newTeamNameTextBox.TabIndex = 12;
            this.newTeamNameTextBox.Text = "Name of the team";
            // 
            // newTeamNameLabel
            // 
            this.newTeamNameLabel.AutoSize = true;
            this.newTeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTeamNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newTeamNameLabel.Location = new System.Drawing.Point(6, 29);
            this.newTeamNameLabel.Name = "newTeamNameLabel";
            this.newTeamNameLabel.Size = new System.Drawing.Size(58, 21);
            this.newTeamNameLabel.TabIndex = 9;
            this.newTeamNameLabel.Text = "Name :";
            this.newTeamNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editTeam
            // 
            this.editTeam.Controls.Add(this.deleteTeamInfoButton);
            this.editTeam.Controls.Add(this.updateTeamInfoButton);
            this.editTeam.Controls.Add(this.groupBox1);
            this.editTeam.Controls.Add(this.groupBox2);
            this.editTeam.Controls.Add(this.updatePrizeInfoLabel);
            this.editTeam.Controls.Add(this.updatableTeamComboBox);
            this.editTeam.Location = new System.Drawing.Point(4, 26);
            this.editTeam.Name = "editTeam";
            this.editTeam.Padding = new System.Windows.Forms.Padding(3);
            this.editTeam.Size = new System.Drawing.Size(532, 486);
            this.editTeam.TabIndex = 1;
            this.editTeam.Text = "Edit";
            this.editTeam.UseVisualStyleBackColor = true;
            // 
            // updateTeamInfoButton
            // 
            this.updateTeamInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTeamInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateTeamInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updateTeamInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updateTeamInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTeamInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTeamInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updateTeamInfoButton.Location = new System.Drawing.Point(41, 419);
            this.updateTeamInfoButton.Name = "updateTeamInfoButton";
            this.updateTeamInfoButton.Size = new System.Drawing.Size(188, 40);
            this.updateTeamInfoButton.TabIndex = 35;
            this.updateTeamInfoButton.Text = "Update this team";
            this.updateTeamInfoButton.UseVisualStyleBackColor = true;
            this.updateTeamInfoButton.Click += new System.EventHandler(this.updateTeamInfoButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.addSelectedTeamMemberToTeamButton);
            this.groupBox1.Controls.Add(this.removeSelectedTeamMemberFromTeamButton);
            this.groupBox1.Controls.Add(this.currentSelectedTeamMembersListBox);
            this.groupBox1.Controls.Add(this.currentSelectableTeamMembersListBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 258);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select team members";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(47, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Selected team members";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSelectedTeamMemberToTeamButton
            // 
            this.addSelectedTeamMemberToTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addSelectedTeamMemberToTeamButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamMemberToTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.addSelectedTeamMemberToTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addSelectedTeamMemberToTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSelectedTeamMemberToTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSelectedTeamMemberToTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addSelectedTeamMemberToTeamButton.Location = new System.Drawing.Point(245, 132);
            this.addSelectedTeamMemberToTeamButton.Name = "addSelectedTeamMemberToTeamButton";
            this.addSelectedTeamMemberToTeamButton.Size = new System.Drawing.Size(22, 33);
            this.addSelectedTeamMemberToTeamButton.TabIndex = 18;
            this.addSelectedTeamMemberToTeamButton.Text = "<";
            this.addSelectedTeamMemberToTeamButton.UseVisualStyleBackColor = true;
            this.addSelectedTeamMemberToTeamButton.Click += new System.EventHandler(this.addSelectedTeamMemberToTeamButton_Click);
            // 
            // removeSelectedTeamMemberFromTeamButton
            // 
            this.removeSelectedTeamMemberFromTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeSelectedTeamMemberFromTeamButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamMemberFromTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.removeSelectedTeamMemberFromTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.removeSelectedTeamMemberFromTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamMemberFromTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedTeamMemberFromTeamButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.removeSelectedTeamMemberFromTeamButton.Location = new System.Drawing.Point(245, 100);
            this.removeSelectedTeamMemberFromTeamButton.Name = "removeSelectedTeamMemberFromTeamButton";
            this.removeSelectedTeamMemberFromTeamButton.Size = new System.Drawing.Size(22, 33);
            this.removeSelectedTeamMemberFromTeamButton.TabIndex = 17;
            this.removeSelectedTeamMemberFromTeamButton.Text = ">";
            this.removeSelectedTeamMemberFromTeamButton.UseVisualStyleBackColor = true;
            this.removeSelectedTeamMemberFromTeamButton.Click += new System.EventHandler(this.removeSelectedTeamMemberFromTeamButton_Click);
            // 
            // currentSelectedTeamMembersListBox
            // 
            this.currentSelectedTeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectedTeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.currentSelectedTeamMembersListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectedTeamMembersListBox.FormattingEnabled = true;
            this.currentSelectedTeamMembersListBox.ItemHeight = 17;
            this.currentSelectedTeamMembersListBox.Location = new System.Drawing.Point(13, 40);
            this.currentSelectedTeamMembersListBox.Name = "currentSelectedTeamMembersListBox";
            this.currentSelectedTeamMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectedTeamMembersListBox.Size = new System.Drawing.Size(214, 189);
            this.currentSelectedTeamMembersListBox.Sorted = true;
            this.currentSelectedTeamMembersListBox.TabIndex = 16;
            // 
            // currentSelectableTeamMembersListBox
            // 
            this.currentSelectableTeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSelectableTeamMembersListBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.currentSelectableTeamMembersListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.currentSelectableTeamMembersListBox.FormattingEnabled = true;
            this.currentSelectableTeamMembersListBox.ItemHeight = 17;
            this.currentSelectableTeamMembersListBox.Location = new System.Drawing.Point(287, 40);
            this.currentSelectableTeamMembersListBox.Name = "currentSelectableTeamMembersListBox";
            this.currentSelectableTeamMembersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.currentSelectableTeamMembersListBox.Size = new System.Drawing.Size(214, 189);
            this.currentSelectableTeamMembersListBox.Sorted = true;
            this.currentSelectableTeamMembersListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updatableTeamNameTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(11, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 65);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Team details";
            // 
            // updatableTeamNameTextBox
            // 
            this.updatableTeamNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatableTeamNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTeamNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTeamNameTextBox.Location = new System.Drawing.Point(63, 25);
            this.updatableTeamNameTextBox.Name = "updatableTeamNameTextBox";
            this.updatableTeamNameTextBox.Size = new System.Drawing.Size(277, 29);
            this.updatableTeamNameTextBox.TabIndex = 12;
            this.updatableTeamNameTextBox.Text = "Name of the team";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "Name :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatePrizeInfoLabel
            // 
            this.updatePrizeInfoLabel.AutoSize = true;
            this.updatePrizeInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeInfoLabel.Location = new System.Drawing.Point(19, 11);
            this.updatePrizeInfoLabel.Name = "updatePrizeInfoLabel";
            this.updatePrizeInfoLabel.Size = new System.Drawing.Size(124, 25);
            this.updatePrizeInfoLabel.TabIndex = 32;
            this.updatePrizeInfoLabel.Text = "Editing Team :";
            this.updatePrizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatableTeamComboBox
            // 
            this.updatableTeamComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatableTeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updatableTeamComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatableTeamComboBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatableTeamComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatableTeamComboBox.FormattingEnabled = true;
            this.updatableTeamComboBox.Location = new System.Drawing.Point(139, 9);
            this.updatableTeamComboBox.Name = "updatableTeamComboBox";
            this.updatableTeamComboBox.Size = new System.Drawing.Size(355, 29);
            this.updatableTeamComboBox.TabIndex = 31;
            this.updatableTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdatableTeamComboBox_SelectedIndexChanged);
            // 
            // deleteTeamInfoButton
            // 
            this.deleteTeamInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTeamInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteTeamInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.deleteTeamInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteTeamInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeamInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deleteTeamInfoButton.Location = new System.Drawing.Point(278, 419);
            this.deleteTeamInfoButton.Name = "deleteTeamInfoButton";
            this.deleteTeamInfoButton.Size = new System.Drawing.Size(188, 40);
            this.deleteTeamInfoButton.TabIndex = 36;
            this.deleteTeamInfoButton.Text = "Delete this team";
            this.deleteTeamInfoButton.UseVisualStyleBackColor = true;
            this.deleteTeamInfoButton.Click += new System.EventHandler(this.deleteTeamInfoButton_Click);
            // 
            // TeamCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.createEditTeamsTabPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "TeamCreatorForm";
            this.Text = "Team Creator";
            this.createEditTeamsTabPanel.ResumeLayout(false);
            this.createTeam.ResumeLayout(false);
            this.createTeam.PerformLayout();
            this.selectTeamMembersGroupBox.ResumeLayout(false);
            this.selectTeamMembersGroupBox.PerformLayout();
            this.addEditMembersTabPanel.ResumeLayout(false);
            this.addMember.ResumeLayout(false);
            this.addMember.PerformLayout();
            this.editMember.ResumeLayout(false);
            this.editMember.PerformLayout();
            this.teamDetailsGroupBox.ResumeLayout(false);
            this.teamDetailsGroupBox.PerformLayout();
            this.editTeam.ResumeLayout(false);
            this.editTeam.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl createEditTeamsTabPanel;
        private System.Windows.Forms.TabPage createTeam;
        private System.Windows.Forms.Button createNewTeamButton;
        private System.Windows.Forms.GroupBox selectTeamMembersGroupBox;
        private System.Windows.Forms.TabControl addEditMembersTabPanel;
        private System.Windows.Forms.TabPage addMember;
        private System.Windows.Forms.Label addNewMemberInfoLabel;
        private System.Windows.Forms.Button addNewMemberButton;
        private System.Windows.Forms.TextBox newMemberPhoneNumberTextBox;
        private System.Windows.Forms.Label newMemberPhoneLabel;
        private System.Windows.Forms.TextBox newMemberEmailTextBox;
        private System.Windows.Forms.Label newMemberEmailLabel;
        private System.Windows.Forms.TextBox newMemberLastNameTextBox;
        private System.Windows.Forms.TextBox newMemberMiddleNameTextBox;
        private System.Windows.Forms.TextBox newMemberFirstNameTextBox;
        private System.Windows.Forms.Label newMemberNameLabel;
        private System.Windows.Forms.TabPage editMember;
        private System.Windows.Forms.Button deleteMemberInfoButton;
        private System.Windows.Forms.Label updateMemberInfoLabel;
        private System.Windows.Forms.ComboBox updatableTeamMembersComboBox;
        private System.Windows.Forms.Button updateMemberInfoButton;
        private System.Windows.Forms.TextBox updateMemberPhoneNumberTextBox;
        private System.Windows.Forms.Label updateMemberPhoneNumberLabel;
        private System.Windows.Forms.TextBox updateMemberEmailTextBox;
        private System.Windows.Forms.Label updateMemberEmailLabel;
        private System.Windows.Forms.TextBox updateMemberLastNameTextBox;
        private System.Windows.Forms.TextBox updateMemberMiddleNameTextBox;
        private System.Windows.Forms.TextBox updateMemberFirstNameTextBox;
        private System.Windows.Forms.Label updateMemberNameLabel;
        private System.Windows.Forms.Label selectedTeamsLabel;
        private System.Windows.Forms.Button removeSelectedTeamMembersButton;
        private System.Windows.Forms.Button addSelectedTeamMembersButton;
        private System.Windows.Forms.ListBox selectedTeamMembersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox selectableTeamMembersListBox;
        private System.Windows.Forms.GroupBox teamDetailsGroupBox;
        private System.Windows.Forms.TextBox newTeamNameTextBox;
        private System.Windows.Forms.Label newTeamNameLabel;
        private System.Windows.Forms.TabPage editTeam;
        private System.Windows.Forms.Button updateTeamInfoButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addSelectedTeamMemberToTeamButton;
        private System.Windows.Forms.Button removeSelectedTeamMemberFromTeamButton;
        private System.Windows.Forms.ListBox currentSelectedTeamMembersListBox;
        private System.Windows.Forms.ListBox currentSelectableTeamMembersListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox updatableTeamNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label updatePrizeInfoLabel;
        private System.Windows.Forms.ComboBox updatableTeamComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deleteTeamInfoButton;
    }
}