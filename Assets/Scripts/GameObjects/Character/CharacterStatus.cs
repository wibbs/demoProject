using System;

namespace GameObjects
{
	public class CharacterStatus {

		#region Public Properties

		public int Strength { get; private set; }
		public int Dexterity { get; private set; }
		public int Endurance { get; private set; }
		public int Intelligence { get; private set; }
		public float MaxEncumberance { get; private set; }

		#endregion


		#region Constructor

		public CharacterStatus()
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


		#region Private Properties



		#endregion



	}
}
