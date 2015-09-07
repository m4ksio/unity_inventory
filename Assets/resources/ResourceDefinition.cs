using System;
using UnityEngine;

namespace ResourceSystem {

public class ResourceDefinition {

		public readonly int Id;
		public readonly ResourceType Type;
		public readonly bool Consumable;
		public readonly Texture Icon;
		public readonly ResourceUnit Unit;
		public readonly double WeightPerUnit;
		public readonly double VolumePerUnit;

		public ResourceDefinition ()
		{


		}

	}
}



