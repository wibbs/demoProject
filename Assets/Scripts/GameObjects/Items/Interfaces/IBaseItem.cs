using System;
using System.Xml.Linq;

namespace GameObjects
{
	public interface IBaseItem : ISavable {

		string Name 
		{
			get;
		}

		float Weight
		{
			get;
		}

		XElement Save();
	}
}