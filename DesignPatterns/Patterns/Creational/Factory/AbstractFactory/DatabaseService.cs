using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public class DatabaseService : Service
{
    public string runService()
    {
        return "database service running";
    }
}

public class DatabaseResponse : Response
{
    public string getResponse()
    {
        return "database response";
    }
}
