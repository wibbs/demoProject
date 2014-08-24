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
    public partial class ArmorEditorWindow : Form
    {
        #region Constructors

        public ArmorEditorWindow(string armorsFilePath)
        {
            Armors = new ObservableCollection<Armor>();

            InitializeComponent();

            _armorFile = armorsFilePath;
            LoadArmors();
            SetBindings();
        }

        #endregion

        #region

        private string _armorFile;

        public ObservableCollection<Armor> Armors { get; set; }

        public Armor SelectedArmor { get; set; }

        private Armor PreviousArmor { get; set; }

        public EquipmentStatTypes SelectedType { get; set; }

        public ObservableCollection<StatTypeEdit<EquipmentStatTypes>> StatTypes { get; set; }

        public StatTypeEdit<EquipmentStatTypes> SelectedStatType { get; set; }

        #endregion



        #region UI Element Events

        private void NewArmorButton_Click(object sender, EventArgs e)
        {
            ArmorsListBox.DataSource = null;
            Armors.Add(new Armor());
            ArmorsListBox.DataSource = Armors;
            ArmorsListBox.DisplayMember = "Name";
        }

        private void DeleteArmorButton_Click(object sender, EventArgs e)
        {
            Armors.Remove(SelectedArmor);

            if (Armors.Count > 0)
                SelectedArmor = Armors[0];
        }

        private void NewStatTypeButton_Click(object sender, EventArgs e)
        {
            StatTypePicker<EquipmentStatTypes> statTypePicker = new StatTypePicker<EquipmentStatTypes>(StatTypes);
            statTypePicker.FormClosing -= statTypePicker_FormClosing;
            statTypePicker.FormClosing += statTypePicker_FormClosing;

            statTypePicker.Show(this);
        }

        void statTypePicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((StatTypePicker<EquipmentStatTypes>)sender).Confirmed)
            {
                StatTypesList.DataSource = null;
                StatTypes.Add(((StatTypePicker<EquipmentStatTypes>)sender).SelectedStatType);
                StatTypesList.DataSource = StatTypes;
                StatTypesList.DisplayMember = "Name";
            }
        }

        private void DeleteStatTypeButton_Click(object sender, EventArgs e)
        {
            StatTypes.Remove(SelectedStatType);

            if (StatTypes.Count > 0)
                SelectedStatType = StatTypes[0];
        }

        private void ArmorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedArmor != null)
            {
                SaveCurrentArmor();
            }

            SelectedArmor = (Armor)((ListBox)sender).SelectedItem;

            if (SelectedArmor != null)
            {
                SaveCurrentArmor();
            }
        }

        private void StatTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedStatType != null)
                SelectedStatType.Value = Convert.ToInt32(StatTypeBonusSelector.Value);

            SelectedStatType = (StatTypeEdit<EquipmentStatTypes>)((ListBox)sender).SelectedItem;

            if (SelectedStatType != null)
                StatTypeBonusSelector.Value = SelectedStatType.Value;
        }


        private void BrowseSpriteButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                SpriteFolderTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void ArmorEditorWindow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void SetCurrentArmor()
        {
            NameTextBox.Text = SelectedArmor.Name;
            DescriptionTextBox.Text = SelectedArmor.Description;
            TypeCombo.SelectedItem = SelectedArmor.ArmorType.ToString();
            RequiredClassCombo.SelectedItem = SelectedArmor.RequiredClass.ToString();
            WeightSelector.Value = (decimal)SelectedArmor.Weight;
            MaxHealthSelector.Value = SelectedArmor.MaxItemHealth;
            CurrentItemHealthSelector.Value = SelectedArmor.CurrentItemHealth;
            StrengthRequirementSelector.Value = SelectedArmor.StrengthRequirement;
            DexterityRequirementSelector.Value = SelectedArmor.DexterityRequirement;
            RootModifierSelector.Value = (decimal)SelectedArmor.RootModifier;
            SpriteFolderTextBox.Text = SelectedArmor.SpritesFolder;
            StatTypesList.DataSource = null;
            StatTypes = new ObservableCollection<StatTypeEdit<EquipmentStatTypes>>();
            foreach (EquipmentStatTypes stat in SelectedArmor.Stats.Keys)
            {
                StatTypes.Add(new StatTypeEdit<EquipmentStatTypes>(stat, SelectedArmor.Stats[stat]));
            }
            StatTypesList.DataSource = StatTypes;
            StatTypesList.DisplayMember = "Name";
        }

        private void SaveCurrentArmor()
        {
            SelectedArmor.Name = NameTextBox.Text;
            SelectedArmor.Description = DescriptionTextBox.Text;
            SelectedArmor.ArmorType = (ArmorTypes)Enum.Parse(typeof(ArmorTypes), (string)TypeCombo.SelectedItem);
            SelectedArmor.RequiredClass = (CharacterClasses)Enum.Parse(typeof(CharacterClasses), (string)RequiredClassCombo.SelectedItem);
            SelectedArmor.Weight = (float)WeightSelector.Value;
            SelectedArmor.MaxItemHealth = Convert.ToInt32(MaxHealthSelector.Value);
            SelectedArmor.CurrentItemHealth = Convert.ToInt32(CurrentItemHealthSelector.Value);
            SelectedArmor.StrengthRequirement = Convert.ToInt32(StrengthRequirementSelector.Value);
            SelectedArmor.DexterityRequirement = Convert.ToInt32(DexterityRequirementSelector.Value);
            SelectedArmor.RootModifier = (float)RootModifierSelector.Value;
            SelectedArmor.SpritesFolder = SpriteFolderTextBox.Text;
            SelectedArmor.Stats = new Dictionary<EquipmentStatTypes, int>();
            foreach (StatTypeEdit<EquipmentStatTypes> stat in StatTypes)
            {
                SelectedArmor.Stats.Add(stat.StatType, stat.Value);
            }
        }

        private void SetBindings()
        {
            StatTypesList.DataSource = StatTypes;
            StatTypesList.DisplayMember = "Name";
            RequiredClassCombo.DataSource = Enum.GetNames(typeof(CharacterClasses));
            TypeCombo.DataSource = Enum.GetNames(typeof(ArmorTypes));
            ArmorsListBox.DataSource = Armors;
            ArmorsListBox.DisplayMember = "Name";
        }

        private void LoadArmors()
        {
            if (File.Exists(_armorFile))
            {
                try
                {
                    XDocument weaponsDoc = XDocument.Load(_armorFile);

                    foreach (XElement armor in weaponsDoc.Element("Armors").Elements())
                    {
                        Armors.Add(new Armor(armor));
                    }

                    if (Armors.Count > 0)
                    {
                        SelectedArmor = Armors[0];
                        SetCurrentArmor();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Failed to parse the armor file.\n" + e.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "The armor file wasn't found");
            }
        }

        private void SaveArmors()
        {
            XElement armorsElement = new XElement("Armors");

            foreach (Armor armor in Armors)
            {
                armorsElement.Add(armor.Save());
            }

            XDocument armorsFile = new XDocument(armorsElement);
            armorsFile.Save(_armorFile);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCurrentArmor();
            SaveArmors();
            Application.Exit();
        }

        #endregion
    }
}
