using UnityEngine;
using System.Collections;
using System.Xml.Linq;

namespace GameObjects
{
	public class Weapon : BaseEquipment, ISavable, IBaseItem {

		#region Properties

		public readonly WeaponTypes WeaponType;

		#endregion


		#region Constructors

		public Weapon(XElement weaponXML): base(weaponXML.Element("Equipment"))
		{
			WeaponType = (WeaponTypes)System.Enum.Parse (typeof(WeaponTypes), weaponXML.Attribute("WeaponType").Value);
		}

		#endregion


		#region Methods	

		public XElement Save()
		{
			XElement weaponData = new XElement ("Weapon", 
			                                    new XAttribute ("WeaponType", WeaponType.ToString ()));

			weaponData.Add(base.Save ());

			return weaponData;
		}	

		#endregion
	}
}