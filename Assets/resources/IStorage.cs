using System;
namespace ResourceSystem
{
	public interface IStorage
	{
		double VolumeLimit;
		double VolumeAvailable;
		bool CanPut(Resource resource, double amount, out double acceptedAmount);
	}
}

