using System;

namespace DesignPatterns.Patterns.Creational.Builder;

public class Apartment(int sqf, int rooms, string city, string state, string kitchen)
{
    private int Sqf { get; } = sqf;
    private int Rooms { get; } = rooms;
    private string City { get; } = city;
    private string State { get; } = state;
    private string Kitchen { get; } = kitchen;

    public void display()
    {
        Console.WriteLine("Apartment has:");
        if (Sqf > -1)
        {
            Console.WriteLine($"{Sqf} Sqf");
        }
        if (Rooms > 0)
        {
            Console.WriteLine($"{Rooms} Rooms");
        }
        if (City != "")
        {
            Console.WriteLine($"{City} City");
        }
        if (City != "")
        {
            Console.WriteLine($"{City} City");
        }
        if (State != "")
        {
            Console.WriteLine($"{State} State");
        }
        if (Kitchen != "")
        {
            Console.WriteLine($"{Kitchen} Kitchen");
        }
    }

}
