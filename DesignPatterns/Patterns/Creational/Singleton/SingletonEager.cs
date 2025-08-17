using System;

namespace DesignPatterns.Patterns.Singleton;

public class SingletonEager
{
    // Eager initialization: instance is created when the class is loaded
    public static SingletonEager eagerInstance { get; } = new SingletonEager();

    // Private constructor to prevent external instantiation
    private SingletonEager() { }

    public static SingletonEager getEagerInstance()
    {
        return eagerInstance;
    }
}
