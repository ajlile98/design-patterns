using System;

namespace DesignPatterns.Patterns.Behavioral.State;

public class GreenLightState : ILightState
{
    public static readonly GreenLightState Instance = new();
    public ILightState CycleChange(StreetLight context)
    {
        return YellowLightState.Instance;
    }

    public string GetCurrentLight()
    {
        return "Green";
    }
}
