namespace ItemEditor
{
    partial class EquipmentStatTypePicker
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
            this.EquipmentStatTypesLabel = new System.Windows.Forms.Label();
            this.EquipmentStatTypesList = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EquipmentStatTypesLabel
            // 
            this.EquipmentStatTypesLabel.AutoSize = true;
            this.EquipmentStatTypesLabel.Location = new System.Drawing.Point(12, 9);
            this.EquipmentStatTypesLabel.Name = "EquipmentStatTypesLabel";
            this.EquipmentStatTypesLabel.Size = new System.Drawing.Size(104, 13);
            this.EquipmentStatTypesLabel.TabIndex = 0;
            this.EquipmentStatTypesLabel.Text = "Available Stat Types";
            // 
            // EquipmentStatTypesList
            // 
            this.EquipmentStatTypesList.FormattingEnabled = true;
            this.EquipmentStatTypesList.Location = new System.Drawing.Point(15, 26);
            this.EquipmentStatTypesList.Name = "EquipmentStatTypesList";
            this.EquipmentStatTypesList.Size = new System.Drawing.Size(120, 225);
            this.EquipmentStatTypesList.TabIndex = 1;
            this.EquipmentStatTypesList.SelectedIndexChanged += new System.EventHandler(this.EquipmentStatTypesList_SelectedIndexChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(143, 26);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(143, 56);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EquipmentStatTypePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 261);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EquipmentStatTypesList);
            this.Controls.Add(this.EquipmentStatTypesLabel);
            this.Name = "EquipmentStatTypePicker";
            this.Text = "Add Stat Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EquipmentStatTypesLabel;
        private System.Windows.Forms.ListBox EquipmentStatTypesList;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}