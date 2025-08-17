using System;
using DesignPatterns.Patterns.Factory.AbstractFactory;

namespace DesignPatterns.Tests;

public class AbstractFactoryTest
{
    [Fact]
    public void TestAbstractFactory()
    {
        Client c1 = new Client(new DatabaseFactory());
        c1.communicate();
        Client c2 = new Client(new NetworkFactory());
        c2.communicate();
    }
}
