using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class Amplifier
{
  public bool Power = false;
  private int _volume;
  private AmplifierMode Mode { get; set; } = AmplifierMode.Surround;

  public int Volume
  {
    get => _volume;
    set
    {
      _volume = Math.Clamp(value, 0, 100);
      Console.WriteLine($"Amplifier: Volume set to {_volume}");
    }
  }

  public void On()
  {
    Console.WriteLine("Amplifier: Turning ON");
    Power = true;
  }
  public void Off()
  {
    Console.WriteLine("Amplifier: Turning OFF");
    Power = false;
  }

  public void SetSurroundSound()
  {
    Mode = AmplifierMode.Surround;
    Console.WriteLine("Amplifier: Set to SURROUND SOUND mode");
  }

  public void SetStereoMode()
  {
    Mode = AmplifierMode.Stereo;
    Console.WriteLine("Amplifier: Set to STEREO mode");
  }
  
}

public enum AmplifierMode
{
  Surround,
  Stereo,
}