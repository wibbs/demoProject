namespace ItemEditor
{
    partial class ConsumableEditorWindow
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
            this.ConsumablesLabel = new System.Windows.Forms.Label();
            this.ConsumablesListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AttributesLabel = new System.Windows.Forms.Label();
            this.AttributesListBox = new System.Windows.Forms.ListBox();
            this.AttributeTurnLengthSelector = new System.Windows.Forms.NumericUpDown();
            this.TurnLengthLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.AttributeValueSelector = new System.Windows.Forms.NumericUpDown();
            this.NewConsumableButton = new System.Windows.Forms.Button();
            this.DeleteConsumableButton = new System.Windows.Forms.Button();
            this.NewAttributeButton = new System.Windows.Forms.Button();
            this.DeleteAttributeButton = new System.Windows.Forms.Button();
            this.WeightSelector = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.BrowseSpriteButton = new System.Windows.Forms.Button();
            this.SpriteFolderTextBox = new System.Windows.Forms.TextBox();
            this.SpritesLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ScriptLocationLabel = new System.Windows.Forms.Label();
            this.ScriptTextBox = new System.Windows.Forms.TextBox();
            this.BrowseScriptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeTurnLengthSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeValueSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).BeginInit();
            this.FormClosed += ConsumableEditorWindow_FormClosed;
            this.SuspendLayout();
            // 
            // ConsumablesLabel
            // 
            this.ConsumablesLabel.AutoSize = true;
            this.ConsumablesLabel.Location = new System.Drawing.Point(12, 9);
            this.ConsumablesLabel.Name = "ConsumablesLabel";
            this.ConsumablesLabel.Size = new System.Drawing.Size(70, 13);
            this.ConsumablesLabel.TabIndex = 0;
            this.ConsumablesLabel.Text = "Consumables";
            // 
            // ConsumablesListBox
            // 
            this.ConsumablesListBox.FormattingEnabled = true;
            this.ConsumablesListBox.Location = new System.Drawing.Point(15, 25);
            this.ConsumablesListBox.Name = "ConsumablesListBox";
            this.ConsumablesListBox.Size = new System.Drawing.Size(120, 264);
            this.ConsumablesListBox.TabIndex = 1;
            this.ConsumablesListBox.SelectedIndexChanged += new System.EventHandler(this.ConsumablesListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(247, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(138, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(138, 48);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(141, 65);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(247, 43);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // AttributesLabel
            // 
            this.AttributesLabel.AutoSize = true;
            this.AttributesLabel.Location = new System.Drawing.Point(138, 111);
            this.AttributesLabel.Name = "AttributesLabel";
            this.AttributesLabel.Size = new System.Drawing.Size(51, 13);
            this.AttributesLabel.TabIndex = 6;
            this.AttributesLabel.Text = "Attributes";
            // 
            // AttributesListBox
            // 
            this.AttributesListBox.FormattingEnabled = true;
            this.AttributesListBox.Location = new System.Drawing.Point(141, 129);
            this.AttributesListBox.Name = "AttributesListBox";
            this.AttributesListBox.Size = new System.Drawing.Size(120, 160);
            this.AttributesListBox.TabIndex = 7;
            this.AttributesListBox.SelectedIndexChanged += new System.EventHandler(this.AttributesListBox_SelectedIndexChanged);
            // 
            // AttributeTurnLengthSelector
            // 
            this.AttributeTurnLengthSelector.Location = new System.Drawing.Point(268, 129);
            this.AttributeTurnLengthSelector.Name = "AttributeTurnLengthSelector";
            this.AttributeTurnLengthSelector.Size = new System.Drawing.Size(120, 20);
            this.AttributeTurnLengthSelector.TabIndex = 8;
            // 
            // TurnLengthLabel
            // 
            this.TurnLengthLabel.AutoSize = true;
            this.TurnLengthLabel.Location = new System.Drawing.Point(265, 113);
            this.TurnLengthLabel.Name = "TurnLengthLabel";
            this.TurnLengthLabel.Size = new System.Drawing.Size(65, 13);
            this.TurnLengthLabel.TabIndex = 9;
            this.TurnLengthLabel.Text = "Turn Length";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(265, 152);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(94, 13);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Value Modification";
            // 
            // AttributeValueSelector
            // 
            this.AttributeValueSelector.Location = new System.Drawing.Point(268, 168);
            this.AttributeValueSelector.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.AttributeValueSelector.Name = "AttributeValueSelector";
            this.AttributeValueSelector.Size = new System.Drawing.Size(120, 20);
            this.AttributeValueSelector.TabIndex = 11;
            // 
            // NewConsumableButton
            // 
            this.NewConsumableButton.Location = new System.Drawing.Point(15, 295);
            this.NewConsumableButton.Name = "NewConsumableButton";
            this.NewConsumableButton.Size = new System.Drawing.Size(48, 23);
            this.NewConsumableButton.TabIndex = 12;
            this.NewConsumableButton.Text = "New";
            this.NewConsumableButton.UseVisualStyleBackColor = true;
            this.NewConsumableButton.Click += new System.EventHandler(this.NewConsumableButton_Click);
            // 
            // DeleteConsumableButton
            // 
            this.DeleteConsumableButton.Location = new System.Drawing.Point(69, 295);
            this.DeleteConsumableButton.Name = "DeleteConsumableButton";
            this.DeleteConsumableButton.Size = new System.Drawing.Size(66, 23);
            this.DeleteConsumableButton.TabIndex = 13;
            this.DeleteConsumableButton.Text = "Delete";
            this.DeleteConsumableButton.UseVisualStyleBackColor = true;
            this.DeleteConsumableButton.Click += new System.EventHandler(this.DeleteConsumableButton_Click);
            // 
            // NewAttributeButton
            // 
            this.NewAttributeButton.Location = new System.Drawing.Point(141, 295);
            this.NewAttributeButton.Name = "NewAttributeButton";
            this.NewAttributeButton.Size = new System.Drawing.Size(48, 23);
            this.NewAttributeButton.TabIndex = 14;
            this.NewAttributeButton.Text = "New";
            this.NewAttributeButton.UseVisualStyleBackColor = true;
            this.NewAttributeButton.Click += new System.EventHandler(this.NewAttributeButton_Click);
            // 
            // DeleteAttributeButton
            // 
            this.DeleteAttributeButton.Location = new System.Drawing.Point(195, 295);
            this.DeleteAttributeButton.Name = "DeleteAttributeButton";
            this.DeleteAttributeButton.Size = new System.Drawing.Size(66, 23);
            this.DeleteAttributeButton.TabIndex = 15;
            this.DeleteAttributeButton.Text = "Delete";
            this.DeleteAttributeButton.UseVisualStyleBackColor = true;
            this.DeleteAttributeButton.Click += new System.EventHandler(this.DeleteAttributeButton_Click);
            // 
            // WeightSelector
            // 
            this.WeightSelector.Location = new System.Drawing.Point(265, 339);
            this.WeightSelector.Name = "WeightSelector";
            this.WeightSelector.Size = new System.Drawing.Size(120, 20);
            this.WeightSelector.TabIndex = 16;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(265, 319);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 17;
            this.WeightLabel.Text = "Weight";
            // 
            // BrowseSpriteButton
            // 
            this.BrowseSpriteButton.Location = new System.Drawing.Point(210, 375);
            this.BrowseSpriteButton.Name = "BrowseSpriteButton";
            this.BrowseSpriteButton.Size = new System.Drawing.Size(50, 23);
            this.BrowseSpriteButton.TabIndex = 35;
            this.BrowseSpriteButton.Text = "Browse";
            this.BrowseSpriteButton.UseVisualStyleBackColor = true;
            this.BrowseSpriteButton.Click += new System.EventHandler(this.BrowseSpriteButton_Click);
            // 
            // SpriteFolderTextBox
            // 
            this.SpriteFolderTextBox.Location = new System.Drawing.Point(14, 377);
            this.SpriteFolderTextBox.Name = "SpriteFolderTextBox";
            this.SpriteFolderTextBox.Size = new System.Drawing.Size(190, 20);
            this.SpriteFolderTextBox.TabIndex = 34;
            // 
            // SpritesLabel
            // 
            this.SpritesLabel.AutoSize = true;
            this.SpritesLabel.Location = new System.Drawing.Point(11, 361);
            this.SpritesLabel.Name = "SpritesLabel";
            this.SpritesLabel.Size = new System.Drawing.Size(71, 13);
            this.SpritesLabel.TabIndex = 33;
            this.SpritesLabel.Text = "Sprites Folder";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(264, 375);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 23);
            this.SaveButton.TabIndex = 36;
            this.SaveButton.Text = "Save and Close";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ScriptLocationLabel
            // 
            this.ScriptLocationLabel.AutoSize = true;
            this.ScriptLocationLabel.Location = new System.Drawing.Point(12, 321);
            this.ScriptLocationLabel.Name = "ScriptLocationLabel";
            this.ScriptLocationLabel.Size = new System.Drawing.Size(116, 13);
            this.ScriptLocationLabel.TabIndex = 37;
            this.ScriptLocationLabel.Text = "Custom Script Location";
            // 
            // ScriptTextBox
            // 
            this.ScriptTextBox.Location = new System.Drawing.Point(15, 338);
            this.ScriptTextBox.Name = "ScriptTextBox";
            this.ScriptTextBox.Size = new System.Drawing.Size(189, 20);
            this.ScriptTextBox.TabIndex = 38;
            // 
            // BrowseScriptButton
            // 
            this.BrowseScriptButton.Location = new System.Drawing.Point(210, 337);
            this.BrowseScriptButton.Name = "BrowseScriptButton";
            this.BrowseScriptButton.Size = new System.Drawing.Size(50, 23);
            this.BrowseScriptButton.TabIndex = 39;
            this.BrowseScriptButton.Text = "Browse";
            this.BrowseScriptButton.UseVisualStyleBackColor = true;
            this.BrowseScriptButton.Click += new System.EventHandler(this.BrowseScriptButton_Click);
            // 
            // ConsumableEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 407);
            this.Controls.Add(this.BrowseScriptButton);
            this.Controls.Add(this.ScriptTextBox);
            this.Controls.Add(this.ScriptLocationLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseSpriteButton);
            this.Controls.Add(this.SpriteFolderTextBox);
            this.Controls.Add(this.SpritesLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WeightSelector);
            this.Controls.Add(this.DeleteAttributeButton);
            this.Controls.Add(this.NewAttributeButton);
            this.Controls.Add(this.DeleteConsumableButton);
            this.Controls.Add(this.NewConsumableButton);
            this.Controls.Add(this.AttributeValueSelector);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.TurnLengthLabel);
            this.Controls.Add(this.AttributeTurnLengthSelector);
            this.Controls.Add(this.AttributesListBox);
            this.Controls.Add(this.AttributesLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ConsumablesListBox);
            this.Controls.Add(this.ConsumablesLabel);
            this.Name = "ConsumableEditorWindow";
            this.Text = "Consumable Editor";
            ((System.ComponentModel.ISupportInitialize)(this.AttributeTurnLengthSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributeValueSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConsumablesLabel;
        private System.Windows.Forms.ListBox ConsumablesListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label AttributesLabel;
        private System.Windows.Forms.ListBox AttributesListBox;
        private System.Windows.Forms.NumericUpDown AttributeTurnLengthSelector;
        private System.Windows.Forms.Label TurnLengthLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.NumericUpDown AttributeValueSelector;
        private System.Windows.Forms.Button NewConsumableButton;
        private System.Windows.Forms.Button DeleteConsumableButton;
        private System.Windows.Forms.Button NewAttributeButton;
        private System.Windows.Forms.Button DeleteAttributeButton;
        private System.Windows.Forms.NumericUpDown WeightSelector;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button BrowseSpriteButton;
        private System.Windows.Forms.TextBox SpriteFolderTextBox;
        private System.Windows.Forms.Label SpritesLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label ScriptLocationLabel;
        private System.Windows.Forms.TextBox ScriptTextBox;
        private System.Windows.Forms.Button BrowseScriptButton;
    }
}