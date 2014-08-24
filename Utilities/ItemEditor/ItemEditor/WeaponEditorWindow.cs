using GameObjects;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;

namespace ItemEditor
{
    public partial class WeaponEditorWindow : Form
    {
        #region Constructors

        public WeaponEditorWindow(string weaponFilePath)
        {
            Weapons = new ObservableCollection<Weapon>();

            InitializeComponent();

            _weaponsFile = weaponFilePath;
            LoadWeapons();
            SetBindings();
        }

        #endregion

        #region Properties

        private string _weaponsFile;

        public ObservableCollection<Weapon> Weapons { get; set; }

        public Weapon SelectedWeapon { get; set; }

        private Weapon PreviousWeapon { get; set; }

        public EquipmentStatTypes SelectedType { get; set; }

        public ObservableCollection<StatTypeEdit<EquipmentStatTypes>> StatTypes { get; set; }

        public StatTypeEdit<EquipmentStatTypes> SelectedStatType { get; set; }

        #endregion

        #region UI Element Events

        private void NewWeaponButton_Click(object sender, EventArgs e)
        {
            WeaponsListBox.DataSource = null;
            Weapons.Add(new Weapon());
            WeaponsListBox.DataSource = Weapons;
            WeaponsListBox.DisplayMember = "Name";
        }

        private void DeleteWeaponButton_Click(object sender, EventArgs e)
        {
            Weapons.Remove(SelectedWeapon);

            if(Weapons.Count > 0)
                SelectedWeapon = Weapons[0];
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

        private void WeaponsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedWeapon != null)
            {
                SaveCurrentWeapon();
            }

            SelectedWeapon = (Weapon)((ListBox)sender).SelectedItem;

            if (SelectedWeapon != null)
            {
                SetCurrentWeapon();
            }
        }

        private void StatTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedStatType != null)
                SelectedStatType.Value = Convert.ToInt32(StatTypeBonusSelector.Value);

            SelectedStatType = (StatTypeEdit<EquipmentStatTypes>)((ListBox)sender).SelectedItem;

            if(SelectedStatType != null)
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

        private void WeaponEditorWindow_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Methods

        private void SetCurrentWeapon()
        {
            WeaponNameTextBox.Text = SelectedWeapon.Name;
            WeaponDesctiptionTextBox.Text = SelectedWeapon.Description;
            WeaponTypeCombo.SelectedItem = SelectedWeapon.WeaponType.ToString();
            RequiredClassesCombo.SelectedItem = SelectedWeapon.RequiredClass.ToString();
            WeightSelector.Value = (decimal)SelectedWeapon.Weight;
            MaxItemHealthSelector.Value = SelectedWeapon.MaxItemHealth;
            CurrentItemHealthSelector.Value = SelectedWeapon.CurrentItemHealth;
            StrengthRequirementSelector.Value = SelectedWeapon.StrengthRequirement;
            DexterityRequirementSelector.Value = SelectedWeapon.DexterityRequirement;
            RootModifierSelector.Value = (decimal)SelectedWeapon.RootModifier;
            SpriteFolderTextBox.Text = SelectedWeapon.SpritesFolder;
            StatTypesList.DataSource = null;
            StatTypes = new ObservableCollection<StatTypeEdit<EquipmentStatTypes>>();
            foreach (EquipmentStatTypes stat in SelectedWeapon.Stats.Keys)
            {
                StatTypes.Add(new StatTypeEdit<EquipmentStatTypes>(stat, SelectedWeapon.Stats[stat]));
            }
            StatTypesList.DataSource = StatTypes;
            StatTypesList.DisplayMember = "Name";
        }

        private void SaveCurrentWeapon()
        {
            SelectedWeapon.Name = WeaponNameTextBox.Text;
            SelectedWeapon.Description = WeaponDesctiptionTextBox.Text;
            SelectedWeapon.WeaponType = (WeaponTypes)Enum.Parse(typeof(WeaponTypes), (string)WeaponTypeCombo.SelectedItem);
            SelectedWeapon.RequiredClass = (CharacterClasses)Enum.Parse(typeof(CharacterClasses), (string)RequiredClassesCombo.SelectedItem);
            SelectedWeapon.Weight = (float)WeightSelector.Value;
            SelectedWeapon.MaxItemHealth = Convert.ToInt32(MaxItemHealthSelector.Value);
            SelectedWeapon.CurrentItemHealth = Convert.ToInt32(CurrentItemHealthSelector.Value);
            SelectedWeapon.StrengthRequirement = Convert.ToInt32(StrengthRequirementSelector.Value);
            SelectedWeapon.DexterityRequirement = Convert.ToInt32(DexterityRequirementSelector.Value);
            SelectedWeapon.RootModifier = (float)RootModifierSelector.Value;
            SelectedWeapon.SpritesFolder = SpriteFolderTextBox.Text;
            SelectedWeapon.Stats = new Dictionary<EquipmentStatTypes, int>();
            foreach (StatTypeEdit<EquipmentStatTypes> stat in StatTypes)
            {
                SelectedWeapon.Stats.Add(stat.StatType, stat.Value);
            }
        }

        private void SetBindings()
        {
            StatTypesList.DataSource = StatTypes;
            StatTypesList.DisplayMember = "Name";
            RequiredClassesCombo.DataSource = Enum.GetNames(typeof(CharacterClasses));
            WeaponTypeCombo.DataSource = Enum.GetNames(typeof(WeaponTypes));
            WeaponsListBox.DataSource = Weapons;
            WeaponsListBox.DisplayMember = "Name";
        }

        private void LoadWeapons()
        {
            if (File.Exists(_weaponsFile))
            {
                try
                {
                    XDocument weaponsDoc = XDocument.Load(_weaponsFile);

                    foreach (XElement weapon in weaponsDoc.Element("Weapons").Elements())
                    {
                        Weapons.Add(new Weapon(weapon));
                    }

                    if (Weapons.Count > 0)
                    {
                        SelectedWeapon = Weapons[0];
                        SetCurrentWeapon();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Failed to parse the weapon file.\n" + e.Message);
                }
            }
            else
            {
                MessageBox.Show(this, "The weapon file wasn't found");
            }
        }

        private void SaveWeapons()
        {
            XElement weaponsElement = new XElement("Weapons");

            foreach (Weapon weapon in Weapons)
            {
                weaponsElement.Add(weapon.Save());
            }

            XDocument weaponsFile = new XDocument(weaponsElement);
            weaponsFile.Save(_weaponsFile);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveCurrentWeapon();
            SaveWeapons();
            Application.Exit();
        }

        #endregion
    }
}
