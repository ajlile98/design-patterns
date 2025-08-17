using System;
using DesignPatterns.Patterns.Creational.Prototype;

namespace DesignPatterns.Tests;

public class PrototypeTest
{
    [Fact]
    public void TestPrototype()
    {
        Vehicle c1 = new Car(3, 30000, "red");
        Vehicle c2 = c1.clone();

        c2.isClone(c1);
        c1.isClone(c2);

        Vehicle b1 = new Bicycle(wheels: 2, price: 1000, cityBike: true);
        Vehicle b2 = b1.clone();

        b2.isClone(b1);
        b1.isClone(b2);

        b1.isClone(c1);
    }
}
