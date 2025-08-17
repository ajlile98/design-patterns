using System;

namespace DesignPatterns.Patterns.Creational.Prototype;

public abstract class Vehicle
{
    public int Wheels { get; set; }
    public long Price { get; set; }

    public Vehicle()
    {

    }
    public Vehicle(Vehicle target)
    {
        if (target != null)
        {
            Wheels = target.Wheels;
            Price = target.Price;
        }
    }

    public abstract Vehicle clone();
    public abstract bool isClone(Vehicle target);
}
