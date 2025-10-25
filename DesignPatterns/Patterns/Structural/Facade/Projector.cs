using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class Projector
{
  public bool Power { get; set; } = false;
  public string Input { get; set; } = "";
  public bool WideScreenMode { get; set; } = false;
  private int _brightness;

  public int Brightness
  {
    get => _brightness;
    set
    {
      _brightness = Math.Clamp(value, 0, 100);
      Console.WriteLine($"Projector: Brightness set to {_brightness}%");
    }
  }

  public void On()
  {
    Power = true;
    Console.WriteLine("Projector: Turning ON");
  }

  public void Off()
  {
    Power = false;
    Console.WriteLine("Projector: Turning OFF");
  }

  public void SetInput(string source)
  {
    Input = source;
    Console.WriteLine($"Projector: Input set to {source}");
  }

  public void SetWideScreenMode()
  {
    WideScreenMode = true;
    Console.WriteLine("Projector: Set to WIDESCREEN mode");
  }

  public void SetStandardMode()
  {
    WideScreenMode = false;
    Console.WriteLine("Projector: Set to STANDARD mode");
  }
}
