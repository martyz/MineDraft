using System;
using System.Collections.Generic;
using System.Text;

public class PressureProvider : Providers
{
    public PressureProvider(string id, float energyOutput) : base(id, energyOutput)
    {
        this.EnergyOutput = energyOutput + energyOutput / 2;
    }
}