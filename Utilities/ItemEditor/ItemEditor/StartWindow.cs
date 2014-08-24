using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace ItemEditor
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Paths.config")))
            {
                LoadSettings();
            }
            else
            {
                MessageBox.Show(this, "Missing settings file");
            }
        }

        private void LoadSettings()
        {
            try
            {
                XDocument settingsDoc = XDocument.Load(Path.Combine(Directory.GetCurrentDirectory(), "Paths.config"));
                ConsumablesTextBox.Text = settingsDoc.Element("Settings").Element("Consumables").Attribute("path").Value;
                ArmorsTextBox.Text = settingsDoc.Element("Settings").Element("Armors").Attribute("path").Value;
                WeaponsTextBox.Text = settingsDoc.Element("Settings").Element("Weapons").Attribute("path").Value;
                DialogTextBox.Text = settingsDoc.Element("Settings").Element("Dialog").Attribute("path").Value;
            }
            catch(Exception e)
            {
                MessageBox.Show(this, "Invalid settings file");
            }
        }

        private void SaveSettings()
        {
            XDocument settingsDoc = new XDocument(new XElement("Settings", new XElement("Consumables", new XAttribute("path", ConsumablesTextBox.Text)),
                                                                           new XElement("Armors", new XAttribute("path", ArmorsTextBox.Text)),
                                                                           new XElement("Weapons", new XAttribute("path", WeaponsTextBox.Text)),
                                                                           new XElement("Dialog", new XAttribute("path", DialogTextBox.Text))));
            settingsDoc.Save(Path.Combine(Directory.GetCurrentDirectory(), "Paths.config"));
        }

        private void ConsumablesButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            ConsumableEditorWindow newWindow = new ConsumableEditorWindow(ConsumablesTextBox.Text);
            newWindow.Show(this);
            this.Hide();
        }

        private void ArmorsButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            ArmorEditorWindow newWindow = new ArmorEditorWindow(ArmorsTextBox.Text);
            newWindow.Show(this);
            this.Hide();
        }

        private void WeaponsButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            WeaponEditorWindow newWindow = new WeaponEditorWindow(WeaponsTextBox.Text);
            newWindow.Show(this);
            this.Hide();
        }

        private void DialogButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void ArmorsLabel_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        void StartWindow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
