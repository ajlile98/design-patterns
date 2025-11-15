using System;

namespace DesignPatterns.Patterns.Behavioral.State;

public interface ILightState
{
 public ILightState CycleChange(StreetLight context);
 string GetCurrentLight();
}
