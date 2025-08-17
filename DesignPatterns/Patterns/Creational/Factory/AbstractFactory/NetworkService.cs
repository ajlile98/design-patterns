using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public class NetworkService : Service
{
    public string runService()
    {
        return "Network service running";
    }
}

public class NetworkResponse : Response
{
    public string getResponse()
    {
        return "Network Response";
    }
}
