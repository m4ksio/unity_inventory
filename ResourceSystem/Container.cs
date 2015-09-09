using System;
using System.Collections.Generic;

namespace ResourceSystem
{
	public class Container : ContainerBase
	{
		public SortedDictionary<int, ResourceDefinition> AcceptedTypes;
		List<Resource> resources;

	    private readonly double _contentWeight;

	    public Container ()
		{

		}



	    public override double ContentWeight
	    {
	        get { return _contentWeight; }
	    }

	    public override double Put(Resource resource, double amount)
	    {
	        throw new NotImplementedException();
	    }

	    public override double Take(Resource resource)
	    {
	        throw new NotImplementedException();
	    }

	    public override bool CanPut(Resource resource, double amount, out double acceptedAmount)
	    {
	        throw new NotImplementedException();
	    }
	}
}

