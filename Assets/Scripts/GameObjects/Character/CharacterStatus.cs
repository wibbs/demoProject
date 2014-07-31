using System;
using System.Xml.Linq;

namespace GameObjects
{
	public class CharacterStatus : ISavable {

		#region Public Properties

		public int Strength { get; private set; }
		public int Dexterity { get; private set; }
		public int Endurance { get; private set; }
		public int Intelligence { get; private set; }
		public float MaxEncumberance { get; private set; }

		#endregion


		#region Constructor

		public CharacterStatus(XElement characterStatusXML)
		{

		}

		#endregion


		#region Read-Only Properties

		public int Health {
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
