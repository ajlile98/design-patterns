using System;

namespace DesignPatterns.Patterns.Structural.Facade;

public class Lights
{
  public bool Power { get; set; } = false;
  private int _brightness;

  public int Brightness
  {
    get => _brightness;
    set
    {
      _brightness = Math.Clamp(value, 0, 100);
      Console.WriteLine($"Lights: Brightness set to {_brightness}%");
    }
  }

  public void On()
  {
    Power = true;
    Brightness = 100;
    Console.WriteLine("Lights: Turning ON");
  }

  public void Off()
  {
    Power = false;
    Brightness = 0;
    Console.WriteLine("Lights: Turning OFF");
  }

  public void Dim(int level)
  {
    Power = true;
    Brightness = level;
    Console.WriteLine($"Lights: Dimmed to {level}%");
  }
}
