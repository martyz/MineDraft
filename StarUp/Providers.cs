using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Providers
    {
    private string id;
    private float energyOutput;

    public Providers(string id, float energyOuput)
    {
        this.Id = id;
        this.EnergyOutput = energyOuput;
    }

    public float EnergyOutput
    {
        get { return energyOutput; }
        set { energyOutput = value; }
    }


    public string Id
    {
        get { return id; }
        set { id = value; }
    }

}

