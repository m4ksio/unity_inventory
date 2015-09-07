using System;
namespace ResourceSystem
{
	public interface IPutTake
	{
		double Put(Resource resource, double amount);
		double Take(Resource resource);
	}
}

