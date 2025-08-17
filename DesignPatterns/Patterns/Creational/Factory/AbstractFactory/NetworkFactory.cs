using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public class NetworkFactory : IDataSourceAbstractFactory
{
    public Response createResponse()
    {
        return new NetworkResponse();
    }

    public Service createService()
    {
        return new NetworkService();
    }
}
