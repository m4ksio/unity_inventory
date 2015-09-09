using System;
using UnityEngine;

namespace ResourceSystem {

[Serializable]
public class ResourceDefinition : ScriptableObject {

		public int Id;
		public ResourceType Type;
		public bool Consumable;
		public Texture Icon;
		public ResourceUnit Unit;
		public double WeightPerUnit;
		public double VolumePerUnit;

		public ResourceDefinition ()
		{


		}

	}
}



