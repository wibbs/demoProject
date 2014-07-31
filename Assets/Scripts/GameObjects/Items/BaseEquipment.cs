using UnityEngine;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GameObjects
{
	public abstract class BaseEquipment : IBaseItem {	

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
		public float Weight { get; private set; }

		#endregion

		#region Constructors

		public BaseEquipment(XElement equipmentXML) 
		{
			Name = equipmentXML.Attribute(Constants.XMLName).Value;
			RequiredClass = (CharacterClasses)System.Enum.Parse(typeof(CharacterClasses), equipmentXML.Attribute(Constants.XMLRequiredClass).Value);
			MaxItemHealth = int.Parse(equipmentXML.Attribute(Constants.XMLMaxItemHealth).Value);
			CurrentItemHealth = int.Parse(equipmentXML.Attribute (Constants.XMLCurrentItemHealth).Value);
			StrengthRequirement = int.Parse(equipmentXML.Attribute (Constants.XMLStrengthRequirement).Value);
			DexterityRequirement = int.Parse(equipmentXML.Attribute (Constants.XMLDexterityRequirement).Value);
			RootModifier = float.Parse(equipmentXML.Attribute (Constants.XMLRootModifier).Value);
			Weight = float.Parse(equipmentXML.Attribute (Constants.XMLWeight).Value);

			foreach (XAttribute attr in equipmentXML.Element(Constants.XMLEquipmentTypesStats).Attributes()) 
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
			XElement equipmentData = new XElement (Constants.XMLEquipment, 
			                                       new XAttribute(Constants.XMLName, Name), 
			                                       new XAttribute(Constants.XMLMaxItemHealth, MaxItemHealth),
			                                       new XAttribute(Constants.XMLCurrentItemHealth, CurrentItemHealth),
			                                       new XAttribute(Constants.XMLStrengthRequirement, StrengthRequirement),
			                                       new XAttribute(Constants.XMLDexterityRequirement, DexterityRequirement),
			                                       new XAttribute(Constants.XMLRootModifier, RootModifier));

			//Add the dynamic stats as a sub-element to the base stats
			XElement equipmentTypesStats = new XElement (Constants.XMLEquipmentTypesStats);
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
