using System;
using System.Xml.Linq;

namespace GameObjects
{
	public class CharacterStatus : ISavable {

		#region Public Properties

		public int Strength { get; set; }
		public int Dexterity { get; set; }
		public int Endurance { get; set; }
		public int Intelligence { get; set; }
		public float MaxEncumberance { get; set; }
        public int CurrentHealth { get; set; }

		#endregion


		#region Constructor

		public CharacterStatus(XElement characterStatusXML)
		{

		}

		#endregion


		#region Read-Only Properties

		public int MaxHealth {
			get {
				return Strength + Endurance;
			}
		}

		public int Dodge {
			get {
				return Dexterity + Intelligence;
			}
		}

		#endregion


		#region Methods

		public XElement Save()
		{
			return null;
		}

		#endregion



	}
}
