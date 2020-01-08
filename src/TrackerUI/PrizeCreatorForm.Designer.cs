namespace TrackerUI
{
    partial class PrizeCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrizeCreatorForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.createNewPrizeButton = new System.Windows.Forms.Button();
            this.addEditPrizesTabPanel = new System.Windows.Forms.TabControl();
            this.addPrize = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPrizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.newPrizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.newPrizeAmountLabel = new System.Windows.Forms.Label();
            this.newPrizePercentageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewPrizeLabel = new System.Windows.Forms.Label();
            this.newPrizePlaceNumberTextBox = new System.Windows.Forms.TextBox();
            this.newPrizePlaceNumberLabel = new System.Windows.Forms.Label();
            this.newPrizeNameTextBox = new System.Windows.Forms.TextBox();
            this.newPrizeNameLabel = new System.Windows.Forms.Label();
            this.editPrize = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prizeAmountToUpdateTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageToUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updatePrizeAmountLabel = new System.Windows.Forms.Label();
            this.updatePrizePercentageLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updatePrizeInfoButton = new System.Windows.Forms.Button();
            this.prizePlaceNumberToUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updatePrizeNumberLabel = new System.Windows.Forms.Label();
            this.prizeNameToUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updatePrizeNameLabel = new System.Windows.Forms.Label();
            this.updatePrizeInfoLabel = new System.Windows.Forms.Label();
            this.updatablePrizesComboBox = new System.Windows.Forms.ComboBox();
            this.deletePrizeInfoButton = new System.Windows.Forms.Button();
            this.addEditPrizesTabPanel.SuspendLayout();
            this.addPrize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.editPrize.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(273, 45);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create a new prize";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createNewPrizeButton
            // 
            this.createNewPrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewPrizeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.createNewPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.createNewPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewPrizeButton.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPrizeButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createNewPrizeButton.Location = new System.Drawing.Point(161, 358);
            this.createNewPrizeButton.Name = "createNewPrizeButton";
            this.createNewPrizeButton.Size = new System.Drawing.Size(188, 40);
            this.createNewPrizeButton.TabIndex = 24;
            this.createNewPrizeButton.Text = "Create this prize";
            this.createNewPrizeButton.UseVisualStyleBackColor = true;
            this.createNewPrizeButton.Click += new System.EventHandler(this.CreateNewPrizeButton_Click);
            // 
            // addEditPrizesTabPanel
            // 
            this.addEditPrizesTabPanel.Controls.Add(this.addPrize);
            this.addEditPrizesTabPanel.Controls.Add(this.editPrize);
            this.addEditPrizesTabPanel.Location = new System.Drawing.Point(12, 69);
            this.addEditPrizesTabPanel.Name = "addEditPrizesTabPanel";
            this.addEditPrizesTabPanel.SelectedIndex = 0;
            this.addEditPrizesTabPanel.Size = new System.Drawing.Size(510, 438);
            this.addEditPrizesTabPanel.TabIndex = 20;
            this.addEditPrizesTabPanel.SelectedIndexChanged += new System.EventHandler(this.AddEditPrizesTabPanel_SelectedIndexChanged);
            // 
            // addPrize
            // 
            this.addPrize.Controls.Add(this.groupBox1);
            this.addPrize.Controls.Add(this.addNewPrizeLabel);
            this.addPrize.Controls.Add(this.createNewPrizeButton);
            this.addPrize.Controls.Add(this.newPrizePlaceNumberTextBox);
            this.addPrize.Controls.Add(this.newPrizePlaceNumberLabel);
            this.addPrize.Controls.Add(this.newPrizeNameTextBox);
            this.addPrize.Controls.Add(this.newPrizeNameLabel);
            this.addPrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addPrize.Location = new System.Drawing.Point(4, 26);
            this.addPrize.Name = "addPrize";
            this.addPrize.Padding = new System.Windows.Forms.Padding(3);
            this.addPrize.Size = new System.Drawing.Size(502, 408);
            this.addPrize.TabIndex = 0;
            this.addPrize.Text = "Add";
            this.addPrize.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newPrizeAmountTextBox);
            this.groupBox1.Controls.Add(this.newPrizePercentageTextBox);
            this.groupBox1.Controls.Add(this.newPrizeAmountLabel);
            this.groupBox1.Controls.Add(this.newPrizePercentageLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 182);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prize amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(279, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "% of total collection";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPrizeAmountTextBox
            // 
            this.newPrizeAmountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPrizeAmountTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizeAmountTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizeAmountTextBox.Location = new System.Drawing.Point(276, 34);
            this.newPrizeAmountTextBox.Name = "newPrizeAmountTextBox";
            this.newPrizeAmountTextBox.Size = new System.Drawing.Size(51, 29);
            this.newPrizeAmountTextBox.TabIndex = 26;
            this.newPrizeAmountTextBox.Text = "0";
            this.newPrizeAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newPrizePercentageTextBox
            // 
            this.newPrizePercentageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPrizePercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizePercentageTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizePercentageTextBox.Location = new System.Drawing.Point(226, 130);
            this.newPrizePercentageTextBox.Name = "newPrizePercentageTextBox";
            this.newPrizePercentageTextBox.Size = new System.Drawing.Size(49, 29);
            this.newPrizePercentageTextBox.TabIndex = 29;
            this.newPrizePercentageTextBox.Text = "0";
            this.newPrizePercentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newPrizeAmountLabel
            // 
            this.newPrizeAmountLabel.AutoSize = true;
            this.newPrizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizeAmountLabel.Location = new System.Drawing.Point(119, 38);
            this.newPrizeAmountLabel.Name = "newPrizeAmountLabel";
            this.newPrizeAmountLabel.Size = new System.Drawing.Size(157, 21);
            this.newPrizeAmountLabel.TabIndex = 25;
            this.newPrizeAmountLabel.Text = "Fixed prize amount : $";
            this.newPrizeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPrizePercentageLabel
            // 
            this.newPrizePercentageLabel.AutoSize = true;
            this.newPrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizePercentageLabel.Location = new System.Drawing.Point(41, 134);
            this.newPrizePercentageLabel.Name = "newPrizePercentageLabel";
            this.newPrizePercentageLabel.Size = new System.Drawing.Size(181, 21);
            this.newPrizePercentageLabel.TabIndex = 28;
            this.newPrizePercentageLabel.Text = "Percentage of collection : ";
            this.newPrizePercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(211, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "- or -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewPrizeLabel
            // 
            this.addNewPrizeLabel.AutoSize = true;
            this.addNewPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPrizeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addNewPrizeLabel.Location = new System.Drawing.Point(19, 11);
            this.addNewPrizeLabel.Name = "addNewPrizeLabel";
            this.addNewPrizeLabel.Size = new System.Drawing.Size(154, 25);
            this.addNewPrizeLabel.TabIndex = 22;
            this.addNewPrizeLabel.Text = "Adding new prize";
            this.addNewPrizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPrizePlaceNumberTextBox
            // 
            this.newPrizePlaceNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPrizePlaceNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizePlaceNumberTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizePlaceNumberTextBox.Location = new System.Drawing.Point(171, 115);
            this.newPrizePlaceNumberTextBox.Name = "newPrizePlaceNumberTextBox";
            this.newPrizePlaceNumberTextBox.Size = new System.Drawing.Size(206, 29);
            this.newPrizePlaceNumberTextBox.TabIndex = 18;
            this.newPrizePlaceNumberTextBox.Text = "New prize place number";
            // 
            // newPrizePlaceNumberLabel
            // 
            this.newPrizePlaceNumberLabel.AutoSize = true;
            this.newPrizePlaceNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizePlaceNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizePlaceNumberLabel.Location = new System.Drawing.Point(19, 119);
            this.newPrizePlaceNumberLabel.Name = "newPrizePlaceNumberLabel";
            this.newPrizePlaceNumberLabel.Size = new System.Drawing.Size(146, 21);
            this.newPrizePlaceNumberLabel.TabIndex = 17;
            this.newPrizePlaceNumberLabel.Text = "Prize place number :";
            this.newPrizePlaceNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newPrizeNameTextBox
            // 
            this.newPrizeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPrizeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizeNameTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizeNameTextBox.Location = new System.Drawing.Point(117, 64);
            this.newPrizeNameTextBox.Name = "newPrizeNameTextBox";
            this.newPrizeNameTextBox.Size = new System.Drawing.Size(260, 29);
            this.newPrizeNameTextBox.TabIndex = 14;
            this.newPrizeNameTextBox.Text = "New prize name";
            // 
            // newPrizeNameLabel
            // 
            this.newPrizeNameLabel.AutoSize = true;
            this.newPrizeNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPrizeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.newPrizeNameLabel.Location = new System.Drawing.Point(19, 68);
            this.newPrizeNameLabel.Name = "newPrizeNameLabel";
            this.newPrizeNameLabel.Size = new System.Drawing.Size(92, 21);
            this.newPrizeNameLabel.TabIndex = 13;
            this.newPrizeNameLabel.Text = "Prize name :";
            this.newPrizeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editPrize
            // 
            this.editPrize.Controls.Add(this.deletePrizeInfoButton);
            this.editPrize.Controls.Add(this.groupBox2);
            this.editPrize.Controls.Add(this.updatePrizeInfoButton);
            this.editPrize.Controls.Add(this.prizePlaceNumberToUpdateTextBox);
            this.editPrize.Controls.Add(this.updatePrizeNumberLabel);
            this.editPrize.Controls.Add(this.prizeNameToUpdateTextBox);
            this.editPrize.Controls.Add(this.updatePrizeNameLabel);
            this.editPrize.Controls.Add(this.updatePrizeInfoLabel);
            this.editPrize.Controls.Add(this.updatablePrizesComboBox);
            this.editPrize.Location = new System.Drawing.Point(4, 26);
            this.editPrize.Name = "editPrize";
            this.editPrize.Padding = new System.Windows.Forms.Padding(3);
            this.editPrize.Size = new System.Drawing.Size(502, 408);
            this.editPrize.TabIndex = 1;
            this.editPrize.Text = "Edit";
            this.editPrize.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prizeAmountToUpdateTextBox);
            this.groupBox2.Controls.Add(this.prizePercentageToUpdateTextBox);
            this.groupBox2.Controls.Add(this.updatePrizeAmountLabel);
            this.groupBox2.Controls.Add(this.updatePrizePercentageLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(23, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 182);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Prize amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(279, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "% of total collection";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prizeAmountToUpdateTextBox
            // 
            this.prizeAmountToUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeAmountToUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountToUpdateTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizeAmountToUpdateTextBox.Location = new System.Drawing.Point(276, 34);
            this.prizeAmountToUpdateTextBox.Name = "prizeAmountToUpdateTextBox";
            this.prizeAmountToUpdateTextBox.Size = new System.Drawing.Size(51, 29);
            this.prizeAmountToUpdateTextBox.TabIndex = 26;
            this.prizeAmountToUpdateTextBox.Text = "-";
            this.prizeAmountToUpdateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prizePercentageToUpdateTextBox
            // 
            this.prizePercentageToUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizePercentageToUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageToUpdateTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizePercentageToUpdateTextBox.Location = new System.Drawing.Point(226, 130);
            this.prizePercentageToUpdateTextBox.Name = "prizePercentageToUpdateTextBox";
            this.prizePercentageToUpdateTextBox.Size = new System.Drawing.Size(49, 29);
            this.prizePercentageToUpdateTextBox.TabIndex = 29;
            this.prizePercentageToUpdateTextBox.Text = "-";
            this.prizePercentageToUpdateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updatePrizeAmountLabel
            // 
            this.updatePrizeAmountLabel.AutoSize = true;
            this.updatePrizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeAmountLabel.Location = new System.Drawing.Point(119, 38);
            this.updatePrizeAmountLabel.Name = "updatePrizeAmountLabel";
            this.updatePrizeAmountLabel.Size = new System.Drawing.Size(157, 21);
            this.updatePrizeAmountLabel.TabIndex = 25;
            this.updatePrizeAmountLabel.Text = "Fixed prize amount : $";
            this.updatePrizeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatePrizePercentageLabel
            // 
            this.updatePrizePercentageLabel.AutoSize = true;
            this.updatePrizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizePercentageLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizePercentageLabel.Location = new System.Drawing.Point(41, 134);
            this.updatePrizePercentageLabel.Name = "updatePrizePercentageLabel";
            this.updatePrizePercentageLabel.Size = new System.Drawing.Size(181, 21);
            this.updatePrizePercentageLabel.TabIndex = 28;
            this.updatePrizePercentageLabel.Text = "Percentage of collection : ";
            this.updatePrizePercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(211, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "- or -";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatePrizeInfoButton
            // 
            this.updatePrizeInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePrizeInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.updatePrizeInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.updatePrizeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePrizeInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeInfoButton.Location = new System.Drawing.Point(24, 358);
            this.updatePrizeInfoButton.Name = "updatePrizeInfoButton";
            this.updatePrizeInfoButton.Size = new System.Drawing.Size(222, 40);
            this.updatePrizeInfoButton.TabIndex = 37;
            this.updatePrizeInfoButton.Text = "Update prize information";
            this.updatePrizeInfoButton.UseVisualStyleBackColor = true;
            this.updatePrizeInfoButton.Click += new System.EventHandler(this.UpdatePrizeInfoButton_Click);
            // 
            // prizePlaceNumberToUpdateTextBox
            // 
            this.prizePlaceNumberToUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizePlaceNumberToUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePlaceNumberToUpdateTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizePlaceNumberToUpdateTextBox.Location = new System.Drawing.Point(173, 115);
            this.prizePlaceNumberToUpdateTextBox.Name = "prizePlaceNumberToUpdateTextBox";
            this.prizePlaceNumberToUpdateTextBox.Size = new System.Drawing.Size(206, 29);
            this.prizePlaceNumberToUpdateTextBox.TabIndex = 36;
            this.prizePlaceNumberToUpdateTextBox.Text = "-";
            // 
            // updatePrizeNumberLabel
            // 
            this.updatePrizeNumberLabel.AutoSize = true;
            this.updatePrizeNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeNumberLabel.Location = new System.Drawing.Point(19, 119);
            this.updatePrizeNumberLabel.Name = "updatePrizeNumberLabel";
            this.updatePrizeNumberLabel.Size = new System.Drawing.Size(146, 21);
            this.updatePrizeNumberLabel.TabIndex = 35;
            this.updatePrizeNumberLabel.Text = "Prize place number :";
            this.updatePrizeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prizeNameToUpdateTextBox
            // 
            this.prizeNameToUpdateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeNameToUpdateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeNameToUpdateTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizeNameToUpdateTextBox.Location = new System.Drawing.Point(119, 64);
            this.prizeNameToUpdateTextBox.Name = "prizeNameToUpdateTextBox";
            this.prizeNameToUpdateTextBox.Size = new System.Drawing.Size(260, 29);
            this.prizeNameToUpdateTextBox.TabIndex = 34;
            this.prizeNameToUpdateTextBox.Text = "<none selected>";
            // 
            // updatePrizeNameLabel
            // 
            this.updatePrizeNameLabel.AutoSize = true;
            this.updatePrizeNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeNameLabel.Location = new System.Drawing.Point(19, 68);
            this.updatePrizeNameLabel.Name = "updatePrizeNameLabel";
            this.updatePrizeNameLabel.Size = new System.Drawing.Size(92, 21);
            this.updatePrizeNameLabel.TabIndex = 33;
            this.updatePrizeNameLabel.Text = "Prize name :";
            this.updatePrizeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatePrizeInfoLabel
            // 
            this.updatePrizeInfoLabel.AutoSize = true;
            this.updatePrizeInfoLabel.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePrizeInfoLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatePrizeInfoLabel.Location = new System.Drawing.Point(19, 11);
            this.updatePrizeInfoLabel.Name = "updatePrizeInfoLabel";
            this.updatePrizeInfoLabel.Size = new System.Drawing.Size(201, 25);
            this.updatePrizeInfoLabel.TabIndex = 32;
            this.updatePrizeInfoLabel.Text = "Editing information for :";
            this.updatePrizeInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatablePrizesComboBox
            // 
            this.updatablePrizesComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatablePrizesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updatablePrizesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatablePrizesComboBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatablePrizesComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updatablePrizesComboBox.FormattingEnabled = true;
            this.updatablePrizesComboBox.Location = new System.Drawing.Point(218, 9);
            this.updatablePrizesComboBox.Name = "updatablePrizesComboBox";
            this.updatablePrizesComboBox.Size = new System.Drawing.Size(276, 29);
            this.updatablePrizesComboBox.TabIndex = 31;
            this.updatablePrizesComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdatablePrizesComboBox_SelectedIndexChanged);
            // 
            // deletePrizeInfoButton
            // 
            this.deletePrizeInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePrizeInfoButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.deletePrizeInfoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.deletePrizeInfoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.deletePrizeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeInfoButton.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeInfoButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.deletePrizeInfoButton.Location = new System.Drawing.Point(258, 358);
            this.deletePrizeInfoButton.Name = "deletePrizeInfoButton";
            this.deletePrizeInfoButton.Size = new System.Drawing.Size(222, 40);
            this.deletePrizeInfoButton.TabIndex = 39;
            this.deletePrizeInfoButton.Text = "Delete prize information";
            this.deletePrizeInfoButton.UseVisualStyleBackColor = true;
            this.deletePrizeInfoButton.Click += new System.EventHandler(this.DeletePrizeInfoButton_Click);
            // 
            // PrizeCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.addEditPrizesTabPanel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 550);
            this.MinimumSize = new System.Drawing.Size(550, 550);
            this.Name = "PrizeCreatorForm";
            this.Text = "Prize Creator";
            this.addEditPrizesTabPanel.ResumeLayout(false);
            this.addPrize.ResumeLayout(false);
            this.addPrize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.editPrize.ResumeLayout(false);
            this.editPrize.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createNewPrizeButton;
        private System.Windows.Forms.TabControl addEditPrizesTabPanel;
        private System.Windows.Forms.TabPage addPrize;
        private System.Windows.Forms.Label addNewPrizeLabel;
        private System.Windows.Forms.TextBox newPrizePlaceNumberTextBox;
        private System.Windows.Forms.Label newPrizePlaceNumberLabel;
        private System.Windows.Forms.TextBox newPrizeNameTextBox;
        private System.Windows.Forms.Label newPrizeNameLabel;
        private System.Windows.Forms.TabPage editPrize;
        private System.Windows.Forms.Label updatePrizeInfoLabel;
        private System.Windows.Forms.ComboBox updatablePrizesComboBox;
        private System.Windows.Forms.TextBox newPrizeAmountTextBox;
        private System.Windows.Forms.Label newPrizeAmountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox newPrizePercentageTextBox;
        private System.Windows.Forms.Label newPrizePercentageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prizeAmountToUpdateTextBox;
        private System.Windows.Forms.TextBox prizePercentageToUpdateTextBox;
        private System.Windows.Forms.Label updatePrizeAmountLabel;
        private System.Windows.Forms.Label updatePrizePercentageLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updatePrizeInfoButton;
        private System.Windows.Forms.TextBox prizePlaceNumberToUpdateTextBox;
        private System.Windows.Forms.Label updatePrizeNumberLabel;
        private System.Windows.Forms.TextBox prizeNameToUpdateTextBox;
        private System.Windows.Forms.Label updatePrizeNameLabel;
        private System.Windows.Forms.Button deletePrizeInfoButton;
    }
}