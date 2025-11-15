using System;
using System.Drawing;

namespace DesignPatterns.Patterns.Behavioral.State;

public class RedLightState : ILightState
{
    public static readonly RedLightState Instance = new();
    public ILightState CycleChange(StreetLight context)
    {
        return GreenLightState.Instance;
    }

    public string GetCurrentLight()
    {
        return "Red"; 
    }
}
