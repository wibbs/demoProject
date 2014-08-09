using GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    public class EquipmentStatTypeEdit
    {
        public EquipmentStatTypes StatType { get; private set; }
        public int Value { get; set; }
        public string Name { get { return StatType.ToString(); } }

        public EquipmentStatTypeEdit(EquipmentStatTypes statType)
        {
            StatType = statType;
            Value = 10;
        }

        public EquipmentStatTypeEdit(EquipmentStatTypes statType, int value)
        {
            StatType = statType;
            Value = value;
        }
    }
}
