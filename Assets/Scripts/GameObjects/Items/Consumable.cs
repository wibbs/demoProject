//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GameObjects
{
	public class Consumable : IBaseItem
	{
		public string Name { get; set; }
        public string Description { get; set; }
		public float Weight { get; set; }
		public string SpritesFolder { get; set; }
        public string CustomScript { get; set; }
        public Dictionary<ConsumableAttributeTypes, ConsumableAttribute> Attributes { get; set; }

        public Consumable()
        {
        }

		public Consumable (XElement consumableXML)
		{
			Name = consumableXML.Attribute(Constants.XMLName).Value;
            Description = consumableXML.Attribute(Constants.XMLDescription).Value;
			Weight = int.Parse(consumableXML.Attribute(Constants.XMLWeight).Value);
			SpritesFolder = consumableXML.Attribute(Constants.XMLSpritesFolder).Value;
            CustomScript = consumableXML.Attribute(Constants.XMLCustomScript).Value;
            Attributes = new Dictionary<ConsumableAttributeTypes, ConsumableAttribute>();

            foreach (XElement element in consumableXML.Elements())
            {
                Attributes.Add((ConsumableAttributeTypes)Enum.Parse(typeof(ConsumableAttributeTypes), element.Name.ToString()), 
                                new ConsumableAttribute() { TurnLength = Int32.Parse(element.Attribute(Constants.XMLTurnLength).Value), 
                                                            Value = Int32.Parse(element.Attribute(Constants.XMLValue).Value) });
            }
		}

		public XElement Save()
		{
			XElement consumableData = new XElement (Constants.XMLConsumable, 
			                                   new XAttribute(Constants.XMLName, Name),
                                               new XAttribute(Constants.XMLDescription, Description),
			                                   new XAttribute(Constants.XMLWeight, Weight),
		                                       new XAttribute(Constants.XMLSpritesFolder, SpritesFolder),
                                               new XAttribute(Constants.XMLCustomScript, CustomScript));

            foreach (ConsumableAttributeTypes attribute in Attributes.Keys)
            {
                consumableData.Add(new XElement(attribute.ToString(), 
                                    new XAttribute(Constants.XMLTurnLength, Attributes[attribute].TurnLength), 
                                    new XAttribute(Constants.XMLValue, Attributes[attribute].Value)));
            }

			return consumableData;
		}
	}
}

