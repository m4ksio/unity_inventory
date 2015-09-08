using System;

namespace ResourceSystem {

public class Resource : IActualSize {
    private readonly int _definitionId;
    private readonly double _amount;


    private int DefinitionId
    {
        get { return _definitionId; }
    }

    private double Amount
    {
        get { return _amount; }
    }

    public Resource ()
	{
	}

    public double Volume { get; set; }
    public double Weight { get; set; }
}
}


