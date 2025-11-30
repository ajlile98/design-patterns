# Design Patterns

A collection of common design patterns implemented in C# to demonstrate their structure, purpose, and usage. Each pattern includes working code examples and unit tests.

## Creational Patterns

### Singleton
Ensures a class has only one instance and provides global access to it. Useful for managing shared resources like database connections or configuration objects. Includes multiple implementations: eager initialization, lazy initialization, thread-safe, and static initialization.

### Factory Method
Provides an interface for creating objects without specifying their exact class. The factory method delegates object creation to subclasses or concrete factory implementations, promoting loose coupling between client code and concrete classes.

### Abstract Factory
Provides an interface for creating families of related objects without specifying their concrete classes. Allows switching between different product families (e.g., different database providers or UI themes) without changing client code.

### Builder
Constructs complex objects step by step using a fluent interface. Separates the construction process from the object representation, making it easier to create objects with many optional parameters or complex initialization logic.

### Prototype
Creates new objects by cloning existing instances rather than creating them from scratch. Useful when object creation is expensive or when you need to create objects with similar configurations.

## Structural Patterns

### Adapter
Allows incompatible interfaces to work together by wrapping an existing class with a new interface. Converts the interface of an existing class into the interface that clients expect, without modifying the original class's source code.

### Bridge
Separates abstraction from implementation, allowing both to vary independently. Useful when you want to share an implementation among multiple objects or switch implementations at runtime.

### Decorator
Adds new functionality to objects dynamically without altering their structure. Provides a flexible alternative to subclassing for extending functionality by wrapping objects in decorator classes.

### Facade
Provides a simplified interface to a complex subsystem. Hides the complexity of multiple classes behind a single, easy-to-use interface, making the subsystem easier to use and understand.

### Proxy
Provides a placeholder or surrogate for another object to control access to it. Can be used for lazy loading, access control, caching, or logging without changing the original object's interface.

## Behavioral Patterns

### Command
Encapsulates requests as objects, allowing you to parameterize clients with different requests, queue operations, and support undo functionality. Decouples the object that invokes the operation from the object that performs it.

### State
Allows an object to alter its behavior when its internal state changes. The object appears to change its class by delegating behavior to state objects that represent different states.

### Strategy
Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Allows the algorithm to vary independently from clients that use it, promoting the open/closed principle.

### Template Method
Defines the skeleton of an algorithm in a base class, letting subclasses override specific steps without changing the algorithm's structure. Promotes code reuse by defining common behavior in the base class.

## Usage

Each pattern is implemented in its own namespace under `DesignPatterns.Patterns` with corresponding unit tests in the `DesignPatterns.Tests` project. To run the tests:

```bash
dotnet test
```

To run tests for a specific pattern:
```bash
dotnet test --filter "PatternName"
```
