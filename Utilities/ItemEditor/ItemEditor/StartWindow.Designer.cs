namespace ItemEditor
{
    partial class StartWindow
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
            this.ConsumablesButton = new System.Windows.Forms.Button();
            this.ArmorsButton = new System.Windows.Forms.Button();
            this.WeaponsButton = new System.Windows.Forms.Button();
            this.DialogButton = new System.Windows.Forms.Button();
            this.ConsumablesLabel = new System.Windows.Forms.Label();
            this.ConsumablesTextBox = new System.Windows.Forms.TextBox();
            this.ArmorsLabel = new System.Windows.Forms.Label();
            this.ArmorsTextBox = new System.Windows.Forms.TextBox();
            this.WeaponsLabel = new System.Windows.Forms.Label();
            this.WeaponsTextBox = new System.Windows.Forms.TextBox();
            this.DialogLabel = new System.Windows.Forms.Label();
            this.DialogTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.FormClosed += StartWindow_FormClosed;
            // 
            // ConsumablesButton
            // 
            this.ConsumablesButton.Location = new System.Drawing.Point(12, 12);
            this.ConsumablesButton.Name = "ConsumablesButton";
            this.ConsumablesButton.Size = new System.Drawing.Size(79, 23);
            this.ConsumablesButton.TabIndex = 0;
            this.ConsumablesButton.Text = "Consumables";
            this.ConsumablesButton.UseVisualStyleBackColor = true;
            this.ConsumablesButton.Click += new System.EventHandler(this.ConsumablesButton_Click);
            // 
            // ArmorsButton
            // 
            this.ArmorsButton.Location = new System.Drawing.Point(97, 12);
            this.ArmorsButton.Name = "ArmorsButton";
            this.ArmorsButton.Size = new System.Drawing.Size(75, 23);
            this.ArmorsButton.TabIndex = 1;
            this.ArmorsButton.Text = "Armors";
            this.ArmorsButton.UseVisualStyleBackColor = true;
            this.ArmorsButton.Click += new System.EventHandler(this.ArmorsButton_Click);
            // 
            // WeaponsButton
            // 
            this.WeaponsButton.Location = new System.Drawing.Point(178, 12);
            this.WeaponsButton.Name = "WeaponsButton";
            this.WeaponsButton.Size = new System.Drawing.Size(75, 23);
            this.WeaponsButton.TabIndex = 2;
            this.WeaponsButton.Text = "Weapons";
            this.WeaponsButton.UseVisualStyleBackColor = true;
            this.WeaponsButton.Click += new System.EventHandler(this.WeaponsButton_Click);
            // 
            // DialogButton
            // 
            this.DialogButton.Location = new System.Drawing.Point(259, 12);
            this.DialogButton.Name = "DialogButton";
            this.DialogButton.Size = new System.Drawing.Size(75, 23);
            this.DialogButton.TabIndex = 3;
            this.DialogButton.Text = "Dialog";
            this.DialogButton.UseVisualStyleBackColor = true;
            this.DialogButton.Click += new System.EventHandler(this.DialogButton_Click);
            // 
            // ConsumablesLabel
            // 
            this.ConsumablesLabel.AutoSize = true;
            this.ConsumablesLabel.Location = new System.Drawing.Point(9, 38);
            this.ConsumablesLabel.Name = "ConsumablesLabel";
            this.ConsumablesLabel.Size = new System.Drawing.Size(89, 13);
            this.ConsumablesLabel.TabIndex = 4;
            this.ConsumablesLabel.Text = "Consumables File";
            // 
            // ConsumablesTextBox
            // 
            this.ConsumablesTextBox.Location = new System.Drawing.Point(12, 54);
            this.ConsumablesTextBox.Name = "ConsumablesTextBox";
            this.ConsumablesTextBox.Size = new System.Drawing.Size(318, 20);
            this.ConsumablesTextBox.TabIndex = 5;
            // 
            // ArmorsLabel
            // 
            this.ArmorsLabel.AutoSize = true;
            this.ArmorsLabel.Location = new System.Drawing.Point(9, 82);
            this.ArmorsLabel.Name = "ArmorsLabel";
            this.ArmorsLabel.Size = new System.Drawing.Size(63, 13);
            this.ArmorsLabel.TabIndex = 6;
            this.ArmorsLabel.Text = "Armors Files";
            this.ArmorsLabel.Click += new System.EventHandler(this.ArmorsLabel_Click);
            // 
            // ArmorsTextBox
            // 
            this.ArmorsTextBox.Location = new System.Drawing.Point(12, 98);
            this.ArmorsTextBox.Name = "ArmorsTextBox";
            this.ArmorsTextBox.Size = new System.Drawing.Size(318, 20);
            this.ArmorsTextBox.TabIndex = 7;
            // 
            // WeaponsLabel
            // 
            this.WeaponsLabel.AutoSize = true;
            this.WeaponsLabel.Location = new System.Drawing.Point(9, 121);
            this.WeaponsLabel.Name = "WeaponsLabel";
            this.WeaponsLabel.Size = new System.Drawing.Size(72, 13);
            this.WeaponsLabel.TabIndex = 8;
            this.WeaponsLabel.Text = "Weapons File";
            // 
            // WeaponsTextBox
            // 
            this.WeaponsTextBox.Location = new System.Drawing.Point(12, 138);
            this.WeaponsTextBox.Name = "WeaponsTextBox";
            this.WeaponsTextBox.Size = new System.Drawing.Size(318, 20);
            this.WeaponsTextBox.TabIndex = 9;
            // 
            // DialogLabel
            // 
            this.DialogLabel.AutoSize = true;
            this.DialogLabel.Location = new System.Drawing.Point(12, 165);
            this.DialogLabel.Name = "DialogLabel";
            this.DialogLabel.Size = new System.Drawing.Size(69, 13);
            this.DialogLabel.TabIndex = 10;
            this.DialogLabel.Text = "Dialog Folder";
            // 
            // DialogTextBox
            // 
            this.DialogTextBox.Location = new System.Drawing.Point(12, 181);
            this.DialogTextBox.Name = "DialogTextBox";
            this.DialogTextBox.Size = new System.Drawing.Size(318, 20);
            this.DialogTextBox.TabIndex = 11;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 219);
            this.Controls.Add(this.DialogTextBox);
            this.Controls.Add(this.DialogLabel);
            this.Controls.Add(this.WeaponsTextBox);
            this.Controls.Add(this.WeaponsLabel);
            this.Controls.Add(this.ArmorsTextBox);
            this.Controls.Add(this.ArmorsLabel);
            this.Controls.Add(this.ConsumablesTextBox);
            this.Controls.Add(this.ConsumablesLabel);
            this.Controls.Add(this.DialogButton);
            this.Controls.Add(this.WeaponsButton);
            this.Controls.Add(this.ArmorsButton);
            this.Controls.Add(this.ConsumablesButton);
            this.Name = "StartWindow";
            this.Text = "Item Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsumablesButton;
        private System.Windows.Forms.Button ArmorsButton;
        private System.Windows.Forms.Button WeaponsButton;
        private System.Windows.Forms.Button DialogButton;
        private System.Windows.Forms.Label ConsumablesLabel;
        private System.Windows.Forms.TextBox ConsumablesTextBox;
        private System.Windows.Forms.Label ArmorsLabel;
        private System.Windows.Forms.TextBox ArmorsTextBox;
        private System.Windows.Forms.Label WeaponsLabel;
        private System.Windows.Forms.TextBox WeaponsTextBox;
        private System.Windows.Forms.Label DialogLabel;
        private System.Windows.Forms.TextBox DialogTextBox;

    }
}

