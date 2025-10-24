using System;

namespace DesignPatterns.Patterns.Structural.Decorator;

public class Coffee
{
  protected virtual string Name { get; set; } = "Coffee";
  public virtual string Drink()
  {
    return $"Drinking my {Name}";
  }

}
