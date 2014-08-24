using GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEditor
{
    public class StatTypeEdit<T>
    {
        public T StatType { get; private set; }
        public int Value { get; set; }
        public string Name { get { return StatType.ToString(); } }
        public int Turns { get; set; }

        public StatTypeEdit(T statType)
        {
            StatType = statType;
            Value = 10;
            Turns = 0;
        }

        public StatTypeEdit(T statType, int value)
        {
            StatType = statType;
            Value = value;
            Turns = 0;
        }

        public StatTypeEdit(T statType, int value, int turns)
        {
            StatType = statType;
            Value = value;
            Turns = turns;
        }
    }
}
