using System;

namespace DesignPatterns.Patterns.Structural.Decorator;

public class EspressoCoffee : Coffee
{
  protected override string Name { get; set; } = "Espresso";
}
