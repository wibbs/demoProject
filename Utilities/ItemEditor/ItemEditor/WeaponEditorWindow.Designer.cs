namespace ItemEditor
{
    partial class WeaponEditorWindow
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
            this.WeaponsLabel = new System.Windows.Forms.Label();
            this.WeaponsListBox = new System.Windows.Forms.ListBox();
            this.NewWeaponButton = new System.Windows.Forms.Button();
            this.DeleteWeaponButton = new System.Windows.Forms.Button();
            this.WeaponNameLabel = new System.Windows.Forms.Label();
            this.WeaponNameTextBox = new System.Windows.Forms.TextBox();
            this.WeaponTypeLabel = new System.Windows.Forms.Label();
            this.MaxItemHealthLabel = new System.Windows.Forms.Label();
            this.MaxItemHealthSelector = new System.Windows.Forms.NumericUpDown();
            this.CurrentItemHealthLabel = new System.Windows.Forms.Label();
            this.CurrentItemHealthSelector = new System.Windows.Forms.NumericUpDown();
            this.StrengthRequirementLabel = new System.Windows.Forms.Label();
            this.StrengthRequirementSelector = new System.Windows.Forms.NumericUpDown();
            this.DexterityRequirementLabel = new System.Windows.Forms.Label();
            this.DexterityRequirementSelector = new System.Windows.Forms.NumericUpDown();
            this.RootModifierLabel = new System.Windows.Forms.Label();
            this.RootModifierSelector = new System.Windows.Forms.NumericUpDown();
            this.StatTypesLabel = new System.Windows.Forms.Label();
            this.StatTypesList = new System.Windows.Forms.ListBox();
            this.StatTypeBonusLabel = new System.Windows.Forms.Label();
            this.StatTypeBonusSelector = new System.Windows.Forms.NumericUpDown();
            this.NewStatTypeButton = new System.Windows.Forms.Button();
            this.DeleteStatTypeButton = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightSelector = new System.Windows.Forms.NumericUpDown();
            this.RequiredClassLabel = new System.Windows.Forms.Label();
            this.RequiredClassesCombo = new System.Windows.Forms.ComboBox();
            this.WeaponTypeCombo = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SpritesLabel = new System.Windows.Forms.Label();
            this.SpriteFolderTextBox = new System.Windows.Forms.TextBox();
            this.BrowseSpriteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxItemHealthSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemHealthSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthRequirementSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityRequirementSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootModifierSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTypeBonusSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).BeginInit();
            this.SuspendLayout();
            this.FormClosing += WeaponEditorWindow_FormClosing;
            // 
            // WeaponsLabel
            // 
            this.WeaponsLabel.AutoSize = true;
            this.WeaponsLabel.Location = new System.Drawing.Point(13, 13);
            this.WeaponsLabel.Name = "WeaponsLabel";
            this.WeaponsLabel.Size = new System.Drawing.Size(53, 13);
            this.WeaponsLabel.TabIndex = 0;
            this.WeaponsLabel.Text = "Weapons";
            // 
            // WeaponsListBox
            // 
            this.WeaponsListBox.DisplayMember = this.Name;
            this.WeaponsListBox.FormattingEnabled = true;
            this.WeaponsListBox.Location = new System.Drawing.Point(16, 30);
            this.WeaponsListBox.Name = "WeaponsListBox";
            this.WeaponsListBox.Size = new System.Drawing.Size(120, 329);
            this.WeaponsListBox.TabIndex = 1;
            this.WeaponsListBox.SelectedIndexChanged += new System.EventHandler(this.WeaponsListBox_SelectedIndexChanged);
            // 
            // NewWeaponButton
            // 
            this.NewWeaponButton.Location = new System.Drawing.Point(16, 365);
            this.NewWeaponButton.Name = "NewWeaponButton";
            this.NewWeaponButton.Size = new System.Drawing.Size(50, 23);
            this.NewWeaponButton.TabIndex = 2;
            this.NewWeaponButton.Text = "New";
            this.NewWeaponButton.UseVisualStyleBackColor = true;
            this.NewWeaponButton.Click += new System.EventHandler(this.NewWeaponButton_Click);
            // 
            // DeleteWeaponButton
            // 
            this.DeleteWeaponButton.Location = new System.Drawing.Point(72, 365);
            this.DeleteWeaponButton.Name = "DeleteWeaponButton";
            this.DeleteWeaponButton.Size = new System.Drawing.Size(63, 23);
            this.DeleteWeaponButton.TabIndex = 3;
            this.DeleteWeaponButton.Text = "Delete";
            this.DeleteWeaponButton.UseVisualStyleBackColor = true;
            this.DeleteWeaponButton.Click += new System.EventHandler(this.DeleteWeaponButton_Click);
            // 
            // WeaponNameLabel
            // 
            this.WeaponNameLabel.AutoSize = true;
            this.WeaponNameLabel.Location = new System.Drawing.Point(143, 13);
            this.WeaponNameLabel.Name = "WeaponNameLabel";
            this.WeaponNameLabel.Size = new System.Drawing.Size(35, 13);
            this.WeaponNameLabel.TabIndex = 4;
            this.WeaponNameLabel.Text = "Name";
            // 
            // WeaponNameTextBox
            // 
            this.WeaponNameTextBox.Location = new System.Drawing.Point(146, 30);
            this.WeaponNameTextBox.Name = "WeaponNameTextBox";
            this.WeaponNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.WeaponNameTextBox.TabIndex = 5;
            // 
            // WeaponTypeLabel
            // 
            this.WeaponTypeLabel.AutoSize = true;
            this.WeaponTypeLabel.Location = new System.Drawing.Point(143, 53);
            this.WeaponTypeLabel.Name = "WeaponTypeLabel";
            this.WeaponTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.WeaponTypeLabel.TabIndex = 6;
            this.WeaponTypeLabel.Text = "Type";
            // 
            // MaxItemHealthLabel
            // 
            this.MaxItemHealthLabel.AutoSize = true;
            this.MaxItemHealthLabel.Location = new System.Drawing.Point(142, 178);
            this.MaxItemHealthLabel.Name = "MaxItemHealthLabel";
            this.MaxItemHealthLabel.Size = new System.Drawing.Size(61, 13);
            this.MaxItemHealthLabel.TabIndex = 8;
            this.MaxItemHealthLabel.Text = "Max Health";
            // 
            // MaxItemHealthSelector
            // 
            this.MaxItemHealthSelector.Location = new System.Drawing.Point(145, 194);
            this.MaxItemHealthSelector.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxItemHealthSelector.Name = "MaxItemHealthSelector";
            this.MaxItemHealthSelector.Size = new System.Drawing.Size(120, 20);
            this.MaxItemHealthSelector.TabIndex = 9;
            // 
            // CurrentItemHealthLabel
            // 
            this.CurrentItemHealthLabel.AutoSize = true;
            this.CurrentItemHealthLabel.Location = new System.Drawing.Point(142, 217);
            this.CurrentItemHealthLabel.Name = "CurrentItemHealthLabel";
            this.CurrentItemHealthLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentItemHealthLabel.TabIndex = 10;
            this.CurrentItemHealthLabel.Text = "Current Health";
            // 
            // CurrentItemHealthSelector
            // 
            this.CurrentItemHealthSelector.Location = new System.Drawing.Point(145, 234);
            this.CurrentItemHealthSelector.Name = "CurrentItemHealthSelector";
            this.CurrentItemHealthSelector.Size = new System.Drawing.Size(120, 20);
            this.CurrentItemHealthSelector.TabIndex = 11;
            // 
            // StrengthRequirementLabel
            // 
            this.StrengthRequirementLabel.AutoSize = true;
            this.StrengthRequirementLabel.Location = new System.Drawing.Point(142, 257);
            this.StrengthRequirementLabel.Name = "StrengthRequirementLabel";
            this.StrengthRequirementLabel.Size = new System.Drawing.Size(110, 13);
            this.StrengthRequirementLabel.TabIndex = 12;
            this.StrengthRequirementLabel.Text = "Strength Requirement";
            // 
            // StrengthRequirementSelector
            // 
            this.StrengthRequirementSelector.Location = new System.Drawing.Point(145, 274);
            this.StrengthRequirementSelector.Name = "StrengthRequirementSelector";
            this.StrengthRequirementSelector.Size = new System.Drawing.Size(120, 20);
            this.StrengthRequirementSelector.TabIndex = 13;
            // 
            // DexterityRequirementLabel
            // 
            this.DexterityRequirementLabel.AutoSize = true;
            this.DexterityRequirementLabel.Location = new System.Drawing.Point(142, 297);
            this.DexterityRequirementLabel.Name = "DexterityRequirementLabel";
            this.DexterityRequirementLabel.Size = new System.Drawing.Size(111, 13);
            this.DexterityRequirementLabel.TabIndex = 14;
            this.DexterityRequirementLabel.Text = "Dexterity Requirement";
            // 
            // DexterityRequirementSelector
            // 
            this.DexterityRequirementSelector.Location = new System.Drawing.Point(145, 314);
            this.DexterityRequirementSelector.Name = "DexterityRequirementSelector";
            this.DexterityRequirementSelector.Size = new System.Drawing.Size(120, 20);
            this.DexterityRequirementSelector.TabIndex = 15;
            // 
            // RootModifierLabel
            // 
            this.RootModifierLabel.AutoSize = true;
            this.RootModifierLabel.Location = new System.Drawing.Point(142, 337);
            this.RootModifierLabel.Name = "RootModifierLabel";
            this.RootModifierLabel.Size = new System.Drawing.Size(107, 13);
            this.RootModifierLabel.TabIndex = 16;
            this.RootModifierLabel.Text = "Ability Modifier Bonus";
            // 
            // RootModifierSelector
            // 
            this.RootModifierSelector.DecimalPlaces = 2;
            this.RootModifierSelector.Location = new System.Drawing.Point(145, 353);
            this.RootModifierSelector.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RootModifierSelector.Name = "RootModifierSelector";
            this.RootModifierSelector.Size = new System.Drawing.Size(120, 20);
            this.RootModifierSelector.TabIndex = 17;
            // 
            // StatTypesLabel
            // 
            this.StatTypesLabel.AutoSize = true;
            this.StatTypesLabel.Location = new System.Drawing.Point(270, 53);
            this.StatTypesLabel.Name = "StatTypesLabel";
            this.StatTypesLabel.Size = new System.Drawing.Size(58, 13);
            this.StatTypesLabel.TabIndex = 18;
            this.StatTypesLabel.Text = "Stat Types";
            // 
            // StatTypesList
            // 
            this.StatTypesList.FormattingEnabled = true;
            this.StatTypesList.Location = new System.Drawing.Point(273, 69);
            this.StatTypesList.Name = "StatTypesList";
            this.StatTypesList.Size = new System.Drawing.Size(120, 264);
            this.StatTypesList.TabIndex = 19;
            this.StatTypesList.SelectedIndexChanged += new System.EventHandler(this.StatTypesList_SelectedIndexChanged);
            // 
            // StatTypeBonusLabel
            // 
            this.StatTypeBonusLabel.AutoSize = true;
            this.StatTypeBonusLabel.Location = new System.Drawing.Point(270, 337);
            this.StatTypeBonusLabel.Name = "StatTypeBonusLabel";
            this.StatTypeBonusLabel.Size = new System.Drawing.Size(86, 13);
            this.StatTypeBonusLabel.TabIndex = 20;
            this.StatTypeBonusLabel.Text = "Stat Type Bonus";
            // 
            // StatTypeBonusSelector
            // 
            this.StatTypeBonusSelector.Location = new System.Drawing.Point(271, 353);
            this.StatTypeBonusSelector.Name = "StatTypeBonusSelector";
            this.StatTypeBonusSelector.Size = new System.Drawing.Size(120, 20);
            this.StatTypeBonusSelector.TabIndex = 21;
            // 
            // NewStatTypeButton
            // 
            this.NewStatTypeButton.Location = new System.Drawing.Point(271, 379);
            this.NewStatTypeButton.Name = "NewStatTypeButton";
            this.NewStatTypeButton.Size = new System.Drawing.Size(55, 23);
            this.NewStatTypeButton.TabIndex = 22;
            this.NewStatTypeButton.Text = "New";
            this.NewStatTypeButton.UseVisualStyleBackColor = true;
            this.NewStatTypeButton.Click += new System.EventHandler(this.NewStatTypeButton_Click);
            // 
            // DeleteStatTypeButton
            // 
            this.DeleteStatTypeButton.Location = new System.Drawing.Point(332, 379);
            this.DeleteStatTypeButton.Name = "DeleteStatTypeButton";
            this.DeleteStatTypeButton.Size = new System.Drawing.Size(59, 23);
            this.DeleteStatTypeButton.TabIndex = 23;
            this.DeleteStatTypeButton.Text = "Delete";
            this.DeleteStatTypeButton.UseVisualStyleBackColor = true;
            this.DeleteStatTypeButton.Click += new System.EventHandler(this.DeleteStatTypeButton_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(143, 138);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 24;
            this.WeightLabel.Text = "Weight";
            // 
            // WeightSelector
            // 
            this.WeightSelector.Location = new System.Drawing.Point(146, 155);
            this.WeightSelector.Name = "WeightSelector";
            this.WeightSelector.Size = new System.Drawing.Size(120, 20);
            this.WeightSelector.TabIndex = 25;
            // 
            // RequiredClassLabel
            // 
            this.RequiredClassLabel.AutoSize = true;
            this.RequiredClassLabel.Location = new System.Drawing.Point(143, 95);
            this.RequiredClassLabel.Name = "RequiredClassLabel";
            this.RequiredClassLabel.Size = new System.Drawing.Size(78, 13);
            this.RequiredClassLabel.TabIndex = 26;
            this.RequiredClassLabel.Text = "Required Class";
            // 
            // RequiredClassesCombo
            // 
            this.RequiredClassesCombo.FormattingEnabled = true;
            this.RequiredClassesCombo.Location = new System.Drawing.Point(146, 111);
            this.RequiredClassesCombo.Name = "RequiredClassesCombo";
            this.RequiredClassesCombo.Size = new System.Drawing.Size(121, 21);
            this.RequiredClassesCombo.TabIndex = 27;
            // 
            // WeaponTypeCombo
            // 
            this.WeaponTypeCombo.FormattingEnabled = true;
            this.WeaponTypeCombo.Location = new System.Drawing.Point(146, 69);
            this.WeaponTypeCombo.Name = "WeaponTypeCombo";
            this.WeaponTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.WeaponTypeCombo.TabIndex = 28;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(271, 408);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 23);
            this.SaveButton.TabIndex = 29;
            this.SaveButton.Text = "Save and Close";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SpritesLabel
            // 
            this.SpritesLabel.AutoSize = true;
            this.SpritesLabel.Location = new System.Drawing.Point(13, 391);
            this.SpritesLabel.Name = "SpritesLabel";
            this.SpritesLabel.Size = new System.Drawing.Size(71, 13);
            this.SpritesLabel.TabIndex = 30;
            this.SpritesLabel.Text = "Sprites Folder";
            // 
            // SpriteFolderTextBox
            // 
            this.SpriteFolderTextBox.Location = new System.Drawing.Point(14, 410);
            this.SpriteFolderTextBox.Name = "SpriteFolderTextBox";
            this.SpriteFolderTextBox.Size = new System.Drawing.Size(195, 20);
            this.SpriteFolderTextBox.TabIndex = 31;
            // 
            // BrowseSpriteButton
            // 
            this.BrowseSpriteButton.Location = new System.Drawing.Point(215, 408);
            this.BrowseSpriteButton.Name = "BrowseSpriteButton";
            this.BrowseSpriteButton.Size = new System.Drawing.Size(50, 23);
            this.BrowseSpriteButton.TabIndex = 32;
            this.BrowseSpriteButton.Text = "Browse";
            this.BrowseSpriteButton.UseVisualStyleBackColor = true;
            this.BrowseSpriteButton.Click += new System.EventHandler(this.BrowseSpriteButton_Click);
            // 
            // WeaponEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 452);
            this.Controls.Add(this.BrowseSpriteButton);
            this.Controls.Add(this.SpriteFolderTextBox);
            this.Controls.Add(this.SpritesLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WeaponTypeCombo);
            this.Controls.Add(this.RequiredClassesCombo);
            this.Controls.Add(this.RequiredClassLabel);
            this.Controls.Add(this.WeightSelector);
            this.Controls.Add(this.WeightLabel);
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
            this.Controls.Add(this.StrengthRequirementSelector);
            this.Controls.Add(this.StrengthRequirementLabel);
            this.Controls.Add(this.CurrentItemHealthSelector);
            this.Controls.Add(this.CurrentItemHealthLabel);
            this.Controls.Add(this.MaxItemHealthSelector);
            this.Controls.Add(this.MaxItemHealthLabel);
            this.Controls.Add(this.WeaponTypeLabel);
            this.Controls.Add(this.WeaponNameTextBox);
            this.Controls.Add(this.WeaponNameLabel);
            this.Controls.Add(this.DeleteWeaponButton);
            this.Controls.Add(this.NewWeaponButton);
            this.Controls.Add(this.WeaponsListBox);
            this.Controls.Add(this.WeaponsLabel);
            this.Name = "WeaponEditorWindow";
            this.Text = "Weapon Editor";
            ((System.ComponentModel.ISupportInitialize)(this.MaxItemHealthSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentItemHealthSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrengthRequirementSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DexterityRequirementSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootModifierSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatTypeBonusSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeaponsLabel;
        private System.Windows.Forms.ListBox WeaponsListBox;
        private System.Windows.Forms.Button NewWeaponButton;
        private System.Windows.Forms.Button DeleteWeaponButton;
        private System.Windows.Forms.Label WeaponNameLabel;
        private System.Windows.Forms.TextBox WeaponNameTextBox;
        private System.Windows.Forms.Label WeaponTypeLabel;
        private System.Windows.Forms.Label MaxItemHealthLabel;
        private System.Windows.Forms.NumericUpDown MaxItemHealthSelector;
        private System.Windows.Forms.Label CurrentItemHealthLabel;
        private System.Windows.Forms.NumericUpDown CurrentItemHealthSelector;
        private System.Windows.Forms.Label StrengthRequirementLabel;
        private System.Windows.Forms.NumericUpDown StrengthRequirementSelector;
        private System.Windows.Forms.Label DexterityRequirementLabel;
        private System.Windows.Forms.NumericUpDown DexterityRequirementSelector;
        private System.Windows.Forms.Label RootModifierLabel;
        private System.Windows.Forms.NumericUpDown RootModifierSelector;
        private System.Windows.Forms.Label StatTypesLabel;
        private System.Windows.Forms.ListBox StatTypesList;
        private System.Windows.Forms.Label StatTypeBonusLabel;
        private System.Windows.Forms.NumericUpDown StatTypeBonusSelector;
        private System.Windows.Forms.Button NewStatTypeButton;
        private System.Windows.Forms.Button DeleteStatTypeButton;
        private System.Windows.Forms.NumericUpDown WeightSelector;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label RequiredClassLabel;
        private System.Windows.Forms.ComboBox WeaponTypeCombo;
        private System.Windows.Forms.ComboBox RequiredClassesCombo;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button BrowseSpriteButton;
        private System.Windows.Forms.TextBox SpriteFolderTextBox;
        private System.Windows.Forms.Label SpritesLabel;
    }
}