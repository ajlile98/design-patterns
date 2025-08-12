using System;

namespace DesignPatterns.Patterns.Factory.FactoryMethod;

public class Pizza : Shape 
{
    public string GetShape()
    {
        return "Round";
    }
}
