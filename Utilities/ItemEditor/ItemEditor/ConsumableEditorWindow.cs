using GameObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ItemEditor
{
    public partial class ConsumableEditorWindow : Form
    {
        #region Constructors

        public ConsumableEditorWindow(string consumableFilePath)
        {
            Consumables = new ObservableCollection<Consumable>();

            InitializeComponent();

            _consumablesFile = consumableFilePath;
            LoadConsumables();
            SetBindings();
        }

        #endregion

        #region Properties

        private string _consumablesFile;

        public ObservableCollection<Consumable> Consumables { get; set; }

        public Consumable SelectedConsumable { get; set; }

        private Consumable PreviousConsumable { get; set; }

        public ConsumableAttributeTypes SelectedType { get; set; }

        public ObservableCollection<StatTypeEdit<ConsumableAttributeTypes>> Attributes { get; set; }

        public StatTypeEdit<ConsumableAttributeTypes> SelectedAttribute { get; set; }

        #endregion

        #region UI Element Events

        private void NewConsumableButton_Click(object sender, EventArgs e)
        {
            ConsumablesListBox.DataSource = null;
            Consumables.Add(new Consumable());
            ConsumablesListBox.DataSource = Consumables;
            ConsumablesListBox.DisplayMember = "Name";
        }

        private void DeleteConsumableButton_Click(object sender, EventArgs e)
        {
            Consumables.Remove(SelectedConsumable);

            if (Consumables.Count > 0)
                SelectedConsumable = Consumables[0];
        }

        private void NewAttributeButton_Click(object sender, EventArgs e)
        {
            StatTypePicker<ConsumableAttributeTypes> statTypePicker = new StatTypePicker<ConsumableAttributeTypes>(Attributes);
            statTypePicker.FormClosing -= statTypePicker_FormClosing;
            statTypePicker.FormClosing += statTypePicker_FormClosing;

            statTypePicker.Show(this);
        }

        void statTypePicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((StatTypePicker<ConsumableAttributeTypes>)sender).Confirmed)
            {
                AttributesListBox.DataSource = null;
                Attributes.Add(((StatTypePicker<ConsumableAttributeTypes>)sender).SelectedStatType);
                AttributesListBox.DataSource = Attributes;
                AttributesListBox.DisplayMember = "Name";
            }
        }

        private void DeleteAttributeButton_Click(object sender, EventArgs e)
        {
            Attributes.Remove(SelectedAttribute);

            if (Attributes.Count > 0)
                SelectedAttribute = Attributes[0];
        }

        private void ConsumablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedConsumable != null)
            {
                SaveCurrentConsumable();
            }

            SelectedConsumable = (Consumable)((ListBox)sender).SelectedItem;

            if (SelectedConsumable != null)
            {
                SetCurrentConsumable();
            }
        }

        private void AttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedAttribute != null)
            {
                SelectedAttribute.Value = Convert.ToInt32(AttributeValueSelector.Value);
                SelectedAttribute.Turns = Convert.ToInt32(AttributeTurnLengthSelector.Value);
            }

            SelectedAttribute = (StatTypeEdit<ConsumableAttributeTypes>)((ListBox)sender).SelectedItem;

            if (SelectedAttribute != null)
            {
                AttributeValueSelector.Value = SelectedAttribute.Value;
                AttributeTurnLengthSelector.Value = SelectedAttribute.Turns;
            }
        }

        private void BrowseSpriteButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                SpriteFolderTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void BrowseScriptButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                ScriptTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void ConsumableEditorWindow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void SetCurrentConsumable()
        {
            NameTextBox.Text = SelectedConsumable.Name;
            DescriptionTextBox.Text = SelectedConsumable.Description;
            WeightSelector.Value = (decimal)SelectedConsumable.Weight;
            SpriteFolderTextBox.Text = SelectedConsumable.SpritesFolder;
            ScriptTextBox.Text = SelectedConsumable.CustomScript;
            AttributesListBox.DataSource = null;
            Attributes = new ObservableCollection<StatTypeEdit<ConsumableAttributeTypes>>();
            foreach (ConsumableAttributeTypes attribute in SelectedConsumable.Attributes.Keys)
            {
                Attributes.Add(new StatTypeEdit<ConsumableAttributeTypes>(attribute, SelectedConsumable.Attributes[attribute].Value, SelectedConsumable.Attributes[attribute].TurnLength));
            }
            AttributesListBox.DataSource = Attributes;
            AttributesListBox.DisplayMember = "Name";
        }

        private void SaveCurrentConsumable()
        {
            SelectedConsumable.Name = NameTextBox.Text;
            SelectedConsumable.Description = DescriptionTextBox.Text;
            SelectedConsumable.Weight = (float)WeightSelector.Value;
            SelectedConsumable.SpritesFolder = SpriteFolderTextBox.Text;
            SelectedConsumable.CustomScript = ScriptTextBox.Text;
            SelectedConsumable.Attributes = new Dictionary<ConsumableAttributeTypes, ConsumableAttribute>();
            foreach (StatTypeEdit<ConsumableAttributeTypes> attribute in Attributes)
            {
                SelectedConsumable.Attributes.Add(attribute.StatType, new ConsumableAttribute() { Value = attribute.Value, TurnLength = attribute.Turns });
            }
        }

        private void SetBindings()
        {
            AttributesListBox.DataSource = Attributes;
            AttributesListBox.DisplayMember = "Name";
            ConsumablesListBox.DataSource = Consumables;
            ConsumablesListBox.DisplayMember = "Name";
        }

        private void LoadConsumables()
        {
            if (File.Exists(_consumablesFile))
            {
                try
                {
                    XDocument weaponsDoc = XDocument.Load(_consumablesFile);

                    foreach (XElement consumable in weaponsDoc.Element("Consumables").Elements())
                    {
                        Consumables.Add(new Consumable(consumable));
                    }

                    if (Consumables.Count > 0)
                    {
                        SelectedConsumable = Consumables[0];
                        SetCurrentConsumable();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Failed to parse the consumables file.\n" + e.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "The consumables file wasn't found");
            }
        }

        private void SaveConsumables()
        {
            XElement consumablesElement = new XElement("Consumables");

            foreach (Consumable consumable in Consumables)
            {
                consumablesElement.Add(consumable.Save());
            }

            XDocument consumablesFile = new XDocument(consumablesElement);
            consumablesFile.Save(_consumablesFile);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCurrentConsumable();
            SaveConsumables();
            Application.Exit();
        }

        #endregion
    }
}
