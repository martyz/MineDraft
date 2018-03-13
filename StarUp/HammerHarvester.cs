using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvesters
{
    public HammerHarvester(string id, double oreOutput, double energyRequierment) : base(id, oreOutput, energyRequierment)
    {
        base.OreOutput = oreOutput * 3;
        base.EnergyRequierment = energyRequierment * 2;
    }
}

