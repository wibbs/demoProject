using UnityEngine;
using System.Collections;

public class CharacterStatus : MonoBehaviour {

	#region Public Properties

	public int Strength = 1;
	public int Dexterity = 1;
	public int Endurance = 1;
	public int Intelligence = 1;

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

	private CharacterInventory _inventory;

	#endregion


	#region Methods

	void Start () {
	
	}
	

	void Update () {
	
	}

	#endregion



}
