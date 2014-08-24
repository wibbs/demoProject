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
    public partial class StatTypePicker<T> : Form
    {
        public ObservableCollection<StatTypeEdit<T>> AvailableStatTypes { get; private set; }
        public StatTypeEdit<T> SelectedStatType { get; set; }
        public bool Confirmed { get; private set; }

        public StatTypePicker(ObservableCollection<StatTypeEdit<T>> currentStatTypes)
        {
            AvailableStatTypes = new ObservableCollection<StatTypeEdit<T>>();
            Confirmed = false;

            InitializeComponent();

            foreach(T stat in Enum.GetValues(typeof(T)))
            {
                if (!currentStatTypes.Where(x => x.StatType.ToString() == stat.ToString()).Any())
                {
                    AvailableStatTypes.Add(new StatTypeEdit<T>(stat));
                }
            }

            StatTypesList.DataSource = AvailableStatTypes;
            StatTypesList.DisplayMember = "Name";

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
            SelectedStatType = (StatTypeEdit<T>)((ListBox)sender).SelectedItem;
        }        
    }
}
