using System;

namespace DesignPatterns.Patterns.Creational.Builder;

public class ApartmentBuilder()
{
    private int Sqf { get; set; } = -1;
    private int Rooms { get; set; } = -1;
    private string City { get; set; } = "";
    private string State { get; set; } = "";
    private string Kitchen { get; set; } = "";

    public ApartmentBuilder setSqf(int sqf)
    {
        Sqf = sqf;
        return this;
    }
    public ApartmentBuilder setRooms(int rooms)
    {
        Rooms = rooms;
        return this;
    }
    public ApartmentBuilder setCity(string city)
    {
        City = city;
        return this;
    }
    public ApartmentBuilder setState(string state)
    {
        State = state;
        return this;
    }
    public ApartmentBuilder setKitchen(string kitchen)
    {
        Kitchen = kitchen;
        return this;
    }

    public Apartment Build()
    {
        Apartment ap = new Apartment(Sqf, Rooms, City, State, Kitchen);
        Sqf = -1;
        Rooms = -1;
        City = "";
        State = "";
        Kitchen = "";
        return ap;
    }

}
