using System;
using DesignPatterns.Patterns.Singleton;

namespace DesignPatterns.Tests;

public class SingletonTest
{
    [Fact]
    public void TestSingletonEager()
    {
        SingletonEager eagetInstance1 = SingletonEager.getEagerInstance();
        SingletonEager eagetInstance2 = SingletonEager.getEagerInstance();
        Console.WriteLine(eagetInstance1);
        Console.WriteLine(eagetInstance2);
    }

    [Fact]
    public void TestSingletonStatic()
    {
        SingletonStatic i1 = SingletonStatic.GetInstance();
        SingletonStatic i2 = SingletonStatic.GetInstance();

        Console.WriteLine(i1);
        Console.WriteLine(i2);
    }

    [Fact]
    public void TestSingletonLazy()
    {
        SingletonLazy i1 = SingletonLazy.GetInstance();
        SingletonLazy i2 = SingletonLazy.GetInstance();

        Console.WriteLine(i1);
        Console.WriteLine(i2);
    }

    [Fact]
    public void TestSingletonThreadSafe()
    {
        SingletonThreadSafe i1 = SingletonThreadSafe.GetInstance();
        SingletonThreadSafe i2 = SingletonThreadSafe.GetInstance();

        Console.WriteLine(i1);
        Console.WriteLine(i2);
    }
}
