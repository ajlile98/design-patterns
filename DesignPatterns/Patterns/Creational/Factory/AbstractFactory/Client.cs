using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public class Client
{
    private Service service;
    private Response response;

    public Client(IDataSourceAbstractFactory factory)
    {
        service = factory.createService();
        response = factory.createResponse();
    }

    public void communicate() {
        if (service != null && response != null)
        {
            Console.WriteLine(service.runService());
            Console.WriteLine(response.getResponse());
        }
    }
}
