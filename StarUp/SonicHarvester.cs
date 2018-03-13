using System;
using System.Collections.Generic;
using System.Text;


public class SonicHarvester : Harvesters
{
    private int SonicFacotr { get; set; }

    public SonicHarvester(string id, double oreOutput, double energyRequierment, int sonicFactor) : base(id, oreOutput, energyRequierment)
    {
        this.SonicFacotr = sonicFactor;
        base.EnergyRequierment = energyRequierment / sonicFactor;
    }

}