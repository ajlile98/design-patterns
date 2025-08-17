using System;

namespace DesignPatterns.Patterns.Factory.FactoryMethod;

public class Burrito : Shape
{
    public string GetShape()
    {
        return "Cylinder";
    }
}
