using System;

namespace DesignPatterns.Patterns.Singleton;

public class SingletonLazy
{
    private static SingletonLazy? lazyInstance;
    private SingletonLazy()
    {
        Console.WriteLine("SingletonLazy first time setup!");
    }

    public static SingletonLazy GetInstance()
    {
        if (lazyInstance == null)
        {
            lazyInstance = new SingletonLazy();
        }
        return lazyInstance;
    }
}
