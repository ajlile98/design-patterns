using System;

namespace DesignPatterns.Patterns.Creational.Prototype;

public class Bicycle : Vehicle
{
    private bool CityBike { get; set; }

    public Bicycle(int wheels, long price, bool cityBike)
    {
        Wheels = wheels;
        Price = price;
        CityBike = cityBike;
    }

    public Bicycle(Bicycle target) : base(target)
    {
        if (target != null)
        {
            this.CityBike = target.CityBike;
        }
    }

    public override Vehicle clone()
    {
        return new Bicycle(this);
    }

    public override bool isClone(Vehicle target)
    {
        if (target is Bicycle)
        {
            Bicycle t = (Bicycle)target;
            if (CityBike == t.CityBike && Wheels == t.Wheels && Price == t.Price)
            {
                Console.WriteLine($"{this} and {t} are clones");
                return true;
            }
        }
        Console.WriteLine($"{this} and {target} are not clones");
        return false;
    }
}
