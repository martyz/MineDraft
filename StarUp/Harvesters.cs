using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Harvesters
    {
    private string id;
    private double oreOutput;
    private double energyRequierment;

    protected Harvesters(string id, double oreOutput, double energyRequierment)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequierment = EnergyRequierment;
    }

    public double EnergyRequierment
    {   
        get { return energyRequierment; }
        set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException("Can not be negative!");
            }
            energyRequierment = value;
        }
    }

    public double OreOutput
    {
        get { return oreOutput; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Can not be negative!");
            }
            oreOutput = value;
        }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}

