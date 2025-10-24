using System;

namespace DesignPatterns.Patterns.Structural.Decorator;

public class MilkDecorator(Coffee _coffee) : Coffee
{
  public override string Drink()
  {
    return _coffee.Drink() + " with Milk";
  }
}
