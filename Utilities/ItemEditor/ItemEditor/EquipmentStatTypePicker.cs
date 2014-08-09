using GameObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ItemEditor
{
    public partial class EquipmentStatTypePicker : Form
    {
        public ObservableCollection<EquipmentStatTypeEdit> AvailableStatTypes { get; private set; }
        public EquipmentStatTypeEdit SelectedStatType { get; set; }
        public bool Confirmed { get; private set; }

        public EquipmentStatTypePicker(ObservableCollection<EquipmentStatTypeEdit> currentStatTypes)
        {
            AvailableStatTypes = new ObservableCollection<EquipmentStatTypeEdit>();
            Confirmed = false;

            InitializeComponent();

            foreach(EquipmentStatTypes stat in Enum.GetValues(typeof(EquipmentStatTypes)))
            {
                if (!currentStatTypes.Where(x => x.StatType == stat).Any())
                {
                    AvailableStatTypes.Add(new EquipmentStatTypeEdit(stat));
                }
            }

            EquipmentStatTypesList.DataSource = AvailableStatTypes;
            EquipmentStatTypesList.DisplayMember = "Name";

            if(AvailableStatTypes.Count > 0)
                SelectedStatType = AvailableStatTypes[0];
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (SelectedStatType != null)
                Confirmed = true;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EquipmentStatTypesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedStatType = (EquipmentStatTypeEdit)((ListBox)sender).SelectedItem;
        }        
    }
}
