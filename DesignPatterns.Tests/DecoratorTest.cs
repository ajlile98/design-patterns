using System;
using DesignPatterns.Patterns.Structural.Decorator;

namespace DesignPatterns.Tests;

public class DecoratorTest
{
  [Fact]
  public void TestDecorator()
  {
    Coffee coffee = new EspressoCoffee();
    coffee = new MilkDecorator(coffee);
    coffee = new SugarDecorator(coffee);

    Console.WriteLine(coffee.Drink());

  }
}
