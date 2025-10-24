using System;

namespace DesignPatterns.Patterns.Structural.Decorator;

public class SugarDecorator(Coffee coffee): Coffee
{
  public override string Drink()
  {
    return coffee.Drink() + " with Sugar";
  }
}
