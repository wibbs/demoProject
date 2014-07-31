using UnityEngine;
using System.Collections;
using System.Xml.Linq;

namespace GameObjects
{
	public class Weapon : BaseEquipment, IBaseItem {

		#region Properties

		public readonly WeaponTypes WeaponType;

		#endregion


		#region Constructors

		public Weapon(XElement weaponXML): base(weaponXML.Element(Constants.XMLEquipment))
		{
			WeaponType = (WeaponTypes)System.Enum.Parse (typeof(WeaponTypes), weaponXML.Attribute(Constants.XMLWeaponType).Value);
		}

		#endregion


		#region Methods	

		public XElement Save()
		{
			XElement weaponData = new XElement (Constants.XMLWeapon, 
			                                    new XAttribute (Constants.XMLWeaponType, WeaponType.ToString ()));

			weaponData.Add(base.Save ());

			return weaponData;
		}	

		#endregion
	}
}