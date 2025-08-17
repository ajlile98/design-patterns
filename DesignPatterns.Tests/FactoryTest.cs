using System;
using DesignPatterns.Patterns.Factory.FactoryMethod;

namespace DesignPatterns.Tests;

public class FactoryTest
{
    ShapeFactory factory = new ShapeFactory();
    [Fact]
    public void TestFactory()
    {
        Shape? roundFood = factory.getFood("Round");
        Shape? cylFood = factory.getFood("Cylinder");

        Assert.NotNull(roundFood);
        Assert.NotNull(cylFood);

        Assert.Equal("Round", roundFood!.GetShape());
        Assert.Equal("Cylinder", cylFood!.GetShape());
        
    }
}
