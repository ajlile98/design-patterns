using System;

namespace DesignPatterns.Patterns.Singleton;

public class SingletonStatic
{
    public static readonly SingletonStatic Instance;

    static SingletonStatic()
    {
        // You can add complex initialization logic here if needed
        Instance = new SingletonStatic();
    }

    private SingletonStatic() { }

    public static SingletonStatic GetInstance()
    {
        return Instance;
    }
}
