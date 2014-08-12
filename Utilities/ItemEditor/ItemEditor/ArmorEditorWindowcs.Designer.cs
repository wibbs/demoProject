namespace ItemEditor
{
    partial class ArmorEditorWindowcs
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
            this.ArmorsLabel = new System.Windows.Forms.Label();
            this.ArmorsListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.RequiredClassLabel = new System.Windows.Forms.Label();
            this.RequiredClassCombo = new System.Windows.Forms.ComboBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightSelector = new System.Windows.Forms.NumericUpDown();
            this.MaxHealthLabel = new System.Windows.Forms.Label();
            this.MaxHealthSelector = new System.Windows.Forms.NumericUpDown();
            this.CurrentHealthSelector = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StrengthRequirementLabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.RootModifierSelector = new System.Windows.Forms.NumericUpDown();
            this.RootModifierLabel = new System.Windows.Forms.Label();
            this.DexterityRequirementSelector = new System.Windows.Forms.NumericUpDown();
            this.DexterityRequirementLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteStatTypeButton = new System.Windows.Forms.Button();
            this.NewStatTypeButton = new System.Windows.Forms.Button();
            this.StatTypeBonusSelector = new System.Windows.Forms.NumericUpDown();
            this.StatTypeBonusLabel = new System.Windows.Forms.Label();
            this.StatTypesList = new System.Windows.Forms.ListBox();
            this.StatTypesLabel = new System.Windows.Forms.Label();
            this.BrowseSpriteButton = new System.Windows.Forms.Button();
            this.SpriteFolderTextBox = new System.Windows.Forms.TextBox();
            this.SpritesLabel = new System.Windows.Forms.Label();
            this.DeleteWeaponButton = new System.Windows.Forms.Button();
            this.NewWeaponButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHealthSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootModifierSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityRequirementSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTypeBonusSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // ArmorsLabel
            // 
            this.ArmorsLabel.AutoSize = true;
            this.ArmorsLabel.Location = new System.Drawing.Point(13, 14);
            this.ArmorsLabel.Name = "ArmorsLabel";
            this.ArmorsLabel.Size = new System.Drawing.Size(39, 13);
            this.ArmorsLabel.TabIndex = 0;
            this.ArmorsLabel.Text = "Armors";
            // 
            // ArmorsListBox
            // 
            this.ArmorsListBox.FormattingEnabled = true;
            this.ArmorsListBox.Location = new System.Drawing.Point(16, 30);
            this.ArmorsListBox.Name = "ArmorsListBox";
            this.ArmorsListBox.Size = new System.Drawing.Size(120, 394);
            this.ArmorsListBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(143, 30);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(250, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(140, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(140, 53);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(143, 70);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(247, 43);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(140, 116);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type";
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(143, 132);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 7;
            // 
            // RequiredClassLabel
            // 
            this.RequiredClassLabel.AutoSize = true;
            this.RequiredClassLabel.Location = new System.Drawing.Point(142, 156);
            this.RequiredClassLabel.Name = "RequiredClassLabel";
            this.RequiredClassLabel.Size = new System.Drawing.Size(78, 13);
            this.RequiredClassLabel.TabIndex = 8;
            this.RequiredClassLabel.Text = "Required Class";
            // 
            // RequiredClassCombo
            // 
            this.RequiredClassCombo.FormattingEnabled = true;
            this.RequiredClassCombo.Location = new System.Drawing.Point(143, 173);
            this.RequiredClassCombo.Name = "RequiredClassCombo";
            this.RequiredClassCombo.Size = new System.Drawing.Size(121, 21);
            this.RequiredClassCombo.TabIndex = 9;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(140, 197);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 10;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightSelector
            // 
            this.WeightSelector.Location = new System.Drawing.Point(143, 214);
            this.WeightSelector.Name = "WeightSelector";
            this.WeightSelector.Size = new System.Drawing.Size(120, 20);
            this.WeightSelector.TabIndex = 11;
            // 
            // MaxHealthLabel
            // 
            this.MaxHealthLabel.AutoSize = true;
            this.MaxHealthLabel.Location = new System.Drawing.Point(142, 237);
            this.MaxHealthLabel.Name = "MaxHealthLabel";
            this.MaxHealthLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxHealthLabel.TabIndex = 12;
            this.MaxHealthLabel.Text = "Max Health";
            // 
            // MaxHealthSelector
            // 
            this.MaxHealthSelector.Location = new System.Drawing.Point(143, 254);
            this.MaxHealthSelector.Name = "MaxHealthSelector";
            this.MaxHealthSelector.Size = new System.Drawing.Size(120, 20);
            this.MaxHealthSelector.TabIndex = 13;
            // 
            // CurrentHealthSelector
            // 
            this.CurrentHealthSelector.AutoSize = true;
            this.CurrentHealthSelector.Location = new System.Drawing.Point(142, 277);
            this.CurrentHealthSelector.Name = "CurrentHealthSelector";
            this.CurrentHealthSelector.Size = new System.Drawing.Size(75, 13);
            this.CurrentHealthSelector.TabIndex = 14;
            this.CurrentHealthSelector.Text = "Current Health";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 294);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // StrengthRequirementLabel
            // 
            this.StrengthRequirementLabel.AutoSize = true;
            this.StrengthRequirementLabel.Location = new System.Drawing.Point(140, 317);
            this.StrengthRequirementLabel.Name = "StrengthRequirementLabel";
            this.StrengthRequirementLabel.Size = new System.Drawing.Size(110, 13);
            this.StrengthRequirementLabel.TabIndex = 16;
            this.StrengthRequirementLabel.Text = "Strength Requirement";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(143, 334);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 17;
            // 
            // RootModifierSelector
            // 
            this.RootModifierSelector.DecimalPlaces = 2;
            this.RootModifierSelector.Location = new System.Drawing.Point(143, 413);
            this.RootModifierSelector.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RootModifierSelector.Name = "RootModifierSelector";
            this.RootModifierSelector.Size = new System.Drawing.Size(120, 20);
            this.RootModifierSelector.TabIndex = 21;
            // 
            // RootModifierLabel
            // 
            this.RootModifierLabel.AutoSize = true;
            this.RootModifierLabel.Location = new System.Drawing.Point(140, 397);
            this.RootModifierLabel.Name = "RootModifierLabel";
            this.RootModifierLabel.Size = new System.Drawing.Size(107, 13);
            this.RootModifierLabel.TabIndex = 20;
            this.RootModifierLabel.Text = "Ability Modifier Bonus";
            // 
            // DexterityRequirementSelector
            // 
            this.DexterityRequirementSelector.Location = new System.Drawing.Point(143, 374);
            this.DexterityRequirementSelector.Name = "DexterityRequirementSelector";
            this.DexterityRequirementSelector.Size = new System.Drawing.Size(120, 20);
            this.DexterityRequirementSelector.TabIndex = 19;
            // 
            // DexterityRequirementLabel
            // 
            this.DexterityRequirementLabel.AutoSize = true;
            this.DexterityRequirementLabel.Location = new System.Drawing.Point(140, 357);
            this.DexterityRequirementLabel.Name = "DexterityRequirementLabel";
            this.DexterityRequirementLabel.Size = new System.Drawing.Size(111, 13);
            this.DexterityRequirementLabel.TabIndex = 18;
            this.DexterityRequirementLabel.Text = "Dexterity Requirement";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(271, 471);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 23);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "Save and Close";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DeleteStatTypeButton
            // 
            this.DeleteStatTypeButton.Location = new System.Drawing.Point(332, 442);
            this.DeleteStatTypeButton.Name = "DeleteStatTypeButton";
            this.DeleteStatTypeButton.Size = new System.Drawing.Size(59, 23);
            this.DeleteStatTypeButton.TabIndex = 35;
            this.DeleteStatTypeButton.Text = "Delete";
            this.DeleteStatTypeButton.UseVisualStyleBackColor = true;
            // 
            // NewStatTypeButton
            // 
            this.NewStatTypeButton.Location = new System.Drawing.Point(271, 442);
            this.NewStatTypeButton.Name = "NewStatTypeButton";
            this.NewStatTypeButton.Size = new System.Drawing.Size(55, 23);
            this.NewStatTypeButton.TabIndex = 34;
            this.NewStatTypeButton.Text = "New";
            this.NewStatTypeButton.UseVisualStyleBackColor = true;
            // 
            // StatTypeBonusSelector
            // 
            this.StatTypeBonusSelector.Location = new System.Drawing.Point(271, 416);
            this.StatTypeBonusSelector.Name = "StatTypeBonusSelector";
            this.StatTypeBonusSelector.Size = new System.Drawing.Size(120, 20);
            this.StatTypeBonusSelector.TabIndex = 33;
            // 
            // StatTypeBonusLabel
            // 
            this.StatTypeBonusLabel.AutoSize = true;
            this.StatTypeBonusLabel.Location = new System.Drawing.Point(270, 400);
            this.StatTypeBonusLabel.Name = "StatTypeBonusLabel";
            this.StatTypeBonusLabel.Size = new System.Drawing.Size(86, 13);
            this.StatTypeBonusLabel.TabIndex = 32;
            this.StatTypeBonusLabel.Text = "Stat Type Bonus";
            // 
            // StatTypesList
            // 
            this.StatTypesList.FormattingEnabled = true;
            this.StatTypesList.Location = new System.Drawing.Point(273, 132);
            this.StatTypesList.Name = "StatTypesList";
            this.StatTypesList.Size = new System.Drawing.Size(120, 264);
            this.StatTypesList.TabIndex = 31;
            // 
            // StatTypesLabel
            // 
            this.StatTypesLabel.AutoSize = true;
            this.StatTypesLabel.Location = new System.Drawing.Point(270, 116);
            this.StatTypesLabel.Name = "StatTypesLabel";
            this.StatTypesLabel.Size = new System.Drawing.Size(58, 13);
            this.StatTypesLabel.TabIndex = 30;
            this.StatTypesLabel.Text = "Stat Types";
            // 
            // BrowseSpriteButton
            // 
            this.BrowseSpriteButton.Location = new System.Drawing.Point(214, 471);
            this.BrowseSpriteButton.Name = "BrowseSpriteButton";
            this.BrowseSpriteButton.Size = new System.Drawing.Size(50, 23);
            this.BrowseSpriteButton.TabIndex = 41;
            this.BrowseSpriteButton.Text = "Browse";
            this.BrowseSpriteButton.UseVisualStyleBackColor = true;
            // 
            // SpriteFolderTextBox
            // 
            this.SpriteFolderTextBox.Location = new System.Drawing.Point(13, 473);
            this.SpriteFolderTextBox.Name = "SpriteFolderTextBox";
            this.SpriteFolderTextBox.Size = new System.Drawing.Size(195, 20);
            this.SpriteFolderTextBox.TabIndex = 40;
            // 
            // SpritesLabel
            // 
            this.SpritesLabel.AutoSize = true;
            this.SpritesLabel.Location = new System.Drawing.Point(10, 457);
            this.SpritesLabel.Name = "SpritesLabel";
            this.SpritesLabel.Size = new System.Drawing.Size(71, 13);
            this.SpritesLabel.TabIndex = 39;
            this.SpritesLabel.Text = "Sprites Folder";
            // 
            // DeleteWeaponButton
            // 
            this.DeleteWeaponButton.Location = new System.Drawing.Point(72, 431);
            this.DeleteWeaponButton.Name = "DeleteWeaponButton";
            this.DeleteWeaponButton.Size = new System.Drawing.Size(63, 23);
            this.DeleteWeaponButton.TabIndex = 38;
            this.DeleteWeaponButton.Text = "Delete";
            this.DeleteWeaponButton.UseVisualStyleBackColor = true;
            // 
            // NewWeaponButton
            // 
            this.NewWeaponButton.Location = new System.Drawing.Point(16, 431);
            this.NewWeaponButton.Name = "NewWeaponButton";
            this.NewWeaponButton.Size = new System.Drawing.Size(50, 23);
            this.NewWeaponButton.TabIndex = 37;
            this.NewWeaponButton.Text = "New";
            this.NewWeaponButton.UseVisualStyleBackColor = true;
            // 
            // ArmorEditorWindowcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 504);
            this.Controls.Add(this.BrowseSpriteButton);
            this.Controls.Add(this.SpriteFolderTextBox);
            this.Controls.Add(this.SpritesLabel);
            this.Controls.Add(this.DeleteWeaponButton);
            this.Controls.Add(this.NewWeaponButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteStatTypeButton);
            this.Controls.Add(this.NewStatTypeButton);
            this.Controls.Add(this.StatTypeBonusSelector);
            this.Controls.Add(this.StatTypeBonusLabel);
            this.Controls.Add(this.StatTypesList);
            this.Controls.Add(this.StatTypesLabel);
            this.Controls.Add(this.RootModifierSelector);
            this.Controls.Add(this.RootModifierLabel);
            this.Controls.Add(this.DexterityRequirementSelector);
            this.Controls.Add(this.DexterityRequirementLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.StrengthRequirementLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.CurrentHealthSelector);
            this.Controls.Add(this.MaxHealthSelector);
            this.Controls.Add(this.MaxHealthLabel);
            this.Controls.Add(this.WeightSelector);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.RequiredClassCombo);
            this.Controls.Add(this.RequiredClassLabel);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ArmorsListBox);
            this.Controls.Add(this.ArmorsLabel);
            this.Name = "ArmorEditorWindowcs";
            this.Text = "ArmorEditorWindowcs";
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHealthSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootModifierSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityRequirementSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTypeBonusSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArmorsLabel;
        private System.Windows.Forms.ListBox ArmorsListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label RequiredClassLabel;
        private System.Windows.Forms.ComboBox RequiredClassCombo;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.NumericUpDown WeightSelector;
        private System.Windows.Forms.Label MaxHealthLabel;
        private System.Windows.Forms.NumericUpDown MaxHealthSelector;
        private System.Windows.Forms.Label CurrentHealthSelector;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label StrengthRequirementLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown RootModifierSelector;
        private System.Windows.Forms.Label RootModifierLabel;
        private System.Windows.Forms.NumericUpDown DexterityRequirementSelector;
        private System.Windows.Forms.Label DexterityRequirementLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteStatTypeButton;
        private System.Windows.Forms.Button NewStatTypeButton;
        private System.Windows.Forms.NumericUpDown StatTypeBonusSelector;
        private System.Windows.Forms.Label StatTypeBonusLabel;
        private System.Windows.Forms.ListBox StatTypesList;
        private System.Windows.Forms.Label StatTypesLabel;
        private System.Windows.Forms.Button BrowseSpriteButton;
        private System.Windows.Forms.TextBox SpriteFolderTextBox;
        private System.Windows.Forms.Label SpritesLabel;
        private System.Windows.Forms.Button DeleteWeaponButton;
        private System.Windows.Forms.Button NewWeaponButton;
    }
}