using System;

namespace DesignPatterns.Patterns.Behavioral.State;

public class StreetLight
{
    private ILightState State {get;set;} = RedLightState.Instance;

    public void TriggerLightCycle()
    {
        State = State.CycleChange(this);
    }

    public string GetCurrentLight()
    {
        return State.GetCurrentLight();
    }

    public ILightState GetCurrentState()
    {
        return State;
    }
}
