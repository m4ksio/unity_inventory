using System;
namespace ResourceSystem
{
	public interface IStorage
	{
		double VolumeLimit { get; set; }
		double VolumeAvailable { get; set; }
		bool CanPut(Resource resource, double amount, out double acceptedAmount);
	}
}

