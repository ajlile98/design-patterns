using System;
using DesignPatterns.Patterns.Creational.Builder;

namespace DesignPatterns.Tests;

public class Builder
{
    [Fact]
    public void TestBuilder() {
        ApartmentBuilder builder = new();
        Apartment ap1 = builder.setSqf(1000)
                                .setRooms(2)
                                .setCity("Orlando")
                                .setState("FL")
                                .setKitchen("true")
                                .Build();
        ap1.display();

        Apartment ap2 = builder.setSqf(1500)
                                .setRooms(3)
                                .setCity("Jacksonville")
                                .setState("FL")
                                .setKitchen("true")
                                .Build();
        ap2.display();
    }
}
