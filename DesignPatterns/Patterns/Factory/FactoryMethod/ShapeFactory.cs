using System;

namespace DesignPatterns.Patterns.Factory.FactoryMethod;

public class ShapeFactory
{
    public Shape? getFood(string type)
    {
        if (type == null)
        {
            throw new ArgumentNullException(nameof(type));
        }
        switch (type)
        {
            case "Round": return new Pizza();
            case "Cylinder": return new Burrito();
            default: throw new ArgumentException("Illegal Argument");
        }
    }
}
