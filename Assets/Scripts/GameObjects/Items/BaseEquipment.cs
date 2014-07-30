using UnityEngine;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GameObjects
{
	public abstract class BaseEquipment : ISavable, IBaseItem {	

		#region Read-Only Properties

		public readonly int StrengthRequirement;
		public readonly int DexterityRequirement;
		public readonly CharacterClasses RequiredClass;

		#endregion

		#region Properties

		public string Name { get; private set; }
		public int MaxItemHealth { get; private set; }
		public int CurrentItemHealth { get; private set; }
		public float RootModifier { get; private set; }
		public Dictionary<EquipmentStatTypes, int> Stats { get; private set; }

		#endregion

		#region Constructors

		public BaseEquipment(XElement equipmentXML) 
		{
			Name = equipmentXML.Attribute("Name").Value;
			RequiredClass = (CharacterClasses)System.Enum.Parse(typeof(CharacterClasses), equipmentXML.Attribute("RequiredClass").Value);
			MaxItemHealth = int.Parse(equipmentXML.Attribute("MaxItemHealth").Value);
			CurrentItemHealth = int.Parse(equipmentXML.Attribute ("CurrentItemHealth").Value);
			StrengthRequirement = int.Parse(equipmentXML.Attribute ("StrengthRequirement").Value);
			DexterityRequirement = int.Parse(equipmentXML.Attribute ("DexterityRequirement").Value);
			RootModifier = float.Parse(equipmentXML.Attribute ("RootModifier").Value);

			foreach (XAttribute attr in equipmentXML.Element("Equipment Types Stats").Attributes()) 
			{
				Stats.Add((EquipmentStatTypes)System.Enum.Parse(typeof(EquipmentStatTypes), attr.Name.ToString()), int.Parse(attr.Value));
			}
		}

		#endregion

		#region Methods

		public int GetStatusValue(EquipmentStatTypes statusType)
		{
			if(!Stats.ContainsKey(statusType))
			   return 0;

		   return Stats[statusType];
		}

		public bool IsBroken()
		{
			return CurrentItemHealth <= 0;
		}

		public void Degrade(int damage)
		{
			CurrentItemHealth -= damage;
		}

		public void Repair()
		{
			CurrentItemHealth = MaxItemHealth;
		}

		public void Upgrade(Dictionary<EquipmentStatTypes, int> statImprovments = null, int itemHealthIncrease = 0)
		{
			MaxItemHealth += itemHealthIncrease;

			if(statImprovments != null)
			{
				foreach(EquipmentStatTypes currentStat in statImprovments.Keys)
				{
					if(Stats.ContainsKey(currentStat))
					{
						Stats[currentStat] += statImprovments[currentStat];
					}
					else
					{
						Stats.Add(currentStat, statImprovments[currentStat]);
					}
				}
			}
		}

		public XElement Save()
		{
			//Add the base stats as attributes
			XElement equipmentData = new XElement ("Equipment", 
			                                       new XAttribute("Name", Name), 
			                                       new XAttribute("MaxItemHealth", MaxItemHealth),
			                                       new XAttribute("CurrentItemHealth", CurrentItemHealth),
			                                       new XAttribute("StrengthRequirement", StrengthRequirement),
			                                       new XAttribute("DexterityRequirement", DexterityRequirement),
			                                       new XAttribute("RootModifier", RootModifier));

			//Add the dynamic stats as a sub-element to the base stats
			XElement equipmentTypesStats = new XElement ("Equipment Types Stats");
			foreach(EquipmentStatTypes statType in Stats.Keys)
			{
				equipmentTypesStats.Add(new XAttribute(statType.ToString(), Stats[statType]));
			}

			equipmentData.Add (equipmentTypesStats);

			return equipmentData;
		}

		#endregion
	}
}
