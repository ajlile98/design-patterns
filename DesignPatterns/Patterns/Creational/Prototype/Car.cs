using System;

namespace DesignPatterns.Patterns.Creational.Prototype;

public class Car : Vehicle
{
    private string Color { get; set; } = "";

    public Car(int wheels, long price, string color)
    {
        Wheels = wheels;
        Price = price;
        Color = color;
    }

    public Car(Car target) : base(target)
    {
        if (target != null)
        {
            Color = target.Color;
        }
    }

    public override Vehicle clone()
    {
        return new Car(this);
    }

    public override bool isClone(Vehicle target)
    {
        if (target is Car)
        {
            Car t = (Car)target;
            if (Color == t.Color && Wheels == t.Wheels && Price == t.Price)
            {
                Console.WriteLine($"{this} and {t} are clones");
                return true;
            }
        }
        Console.WriteLine($"{this} and {target} are not clones");
        return false;
    }
}
