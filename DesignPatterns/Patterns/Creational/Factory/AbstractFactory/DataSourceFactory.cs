using System;

namespace DesignPatterns.Patterns.Factory.AbstractFactory;

public interface Service
{
    string runService();
}
public interface Response
{
    string getResponse();
}
public interface IDataSourceAbstractFactory
{
    Service createService();
    Response createResponse();
}
