# Design Patterns

## I wanted to learn more about design patterns so here are some very basic implementations of some

## Creational
### Singleton
Singleton Pattern's goal is to save on resources by creating static objects to be shared across required users of the resource.
Potentially good for database connections, API Services, anything that has a connection to it.
This pattern sounds like it is bad for testing and dependency injection methods reduce the need for this pattern

### Factory
A factory is a way to abstract object creation from the client. Each Item in a factory would implement an interface or abstract class to be returned to the client.
For example being able to provide multiple payment providers to a client. The factory pattern also allows application extendability. To add a new payment processor we can simply write a new factory that implements our PaymentProcessor interface. This leads to our Abstract Factory Patter

### AbstractFactory
The abstract factory pattern is a factory of factories. The best example of this is a DataAccessFactory that provides different factories that can provide data in different methods. The client just wants their data, but doesnt care how so we create an abstract factory to do this easily.  

### Builder
Builder is a fairly straight forward pattern. In an example where we have many options to configure an object, the builder pattern allows us to easily build our custom object type by providing a chainable interaction that builds the object when called. This is implemented by having a series of setter functions for each property type that returns the object itself with "this" statement. Then finally we use a Build() method to build the final object we want to create.

### Prototype
