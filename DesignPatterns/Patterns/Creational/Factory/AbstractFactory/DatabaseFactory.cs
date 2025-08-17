using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public class DatabaseFactory : IDataSourceAbstractFactory
{
    public Response createResponse()
    {
        return new DatabaseResponse();
    }

    public Service createService()
    {
        return new DatabaseService();
    }
}
