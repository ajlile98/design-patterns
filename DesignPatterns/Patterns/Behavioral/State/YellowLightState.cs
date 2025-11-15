using System;

namespace DesignPatterns.Patterns.Behavioral.State;

public class YellowLightState : ILightState
{
    public static readonly YellowLightState Instance = new();
    public ILightState CycleChange(StreetLight context)
    {
        return RedLightState.Instance;
    }

    public string GetCurrentLight()
    {
        return "Yellow";
    }
}
