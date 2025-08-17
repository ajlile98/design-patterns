using System;
using System.ComponentModel;

namespace DesignPatterns.Patterns.Singleton;

public class SingletonThreadSafe
{
    private static SingletonThreadSafe? instance;
    private static readonly object padlock = new object();

    private SingletonThreadSafe()
    {
        Console.WriteLine("SingletonThreadSafe: First time setup!");
    }

    public static SingletonThreadSafe GetInstance()
    {
        if (instance == null)
        {
            lock (padlock)
            {
                instance = new SingletonThreadSafe();
            }
        }
        return instance;
    }
}
