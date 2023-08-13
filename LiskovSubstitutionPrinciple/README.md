# Liskov Substitution Principle

The Liskov Substitution Principle (LSP) states that objects of a derived class must be substitutable for objects of the base class without affecting the correctness of the program. In other words, if a program is using an instance of a base class, it should be able to replace it with an instance of a derived class without causing any unexpected behavior.

## Applying Liskov Substitution Principle

Consider the example of road and rail vehicles that implement the IMovable and ITurnable interfaces.


## Bad Design

In the bad design example, the `Train` class inherits from the `Vehicle` class, but it violates the LSP. The `TurnLeft` and `TurnRight` methods, which are part of the behavior defined by the `Vehicle` class, are not applicable to the `Train` class. This violation makes it problematic to use instances of the `Train` class interchangeably with instances of the `Vehicle` class, as it contradicts the expected behavior.

```C#
public class Vehicle
{
    public float Speed = 10f;

    public void GoForward()
    {
        // Implementation details...
    }

    public void Reverse()
    {
        // Implementation details...
    }

    public void TurnRight()
    {
        // Implementation details...
    }

    public void TurnLeft()
    {
        // Implementation details...
    }
}

public class Train : Vehicle
{
    // Train-specific implementation, no need for TurnLeft and TurnRight
}

```

## Good Design

In the good design , the `Car` and `Truck` classes derive from the foundational `RoadVehicle` class, while the `Train` and `Tram` classes inherit attributes from the `RailVehicle` class. This design strategy not only promotes code reusability but also ensures a structured and organized hierarchy within the system.

```C#
public interface ITurnable
{
    void TurnRight();
    void TurnLeft();
}
public interface IMovable
{
    void GoForward();
    void GoBackward();
}

public class RoadVehicle : IMovable, ITurnable
{
    public float speed = 50f;
    public float turnSpeed = 2f;

    public virtual void GoForward()
    {
        // Implementation specific to road vehicles
    }

    public virtual void GoBackward()
    {
        // Implementation specific to road vehicles
    }

    public virtual void TurnLeft()
    {
        // Implementation specific to road vehicles
    }

    public virtual void TurnRight()
    {
        // Implementation specific to road vehicles
    }
}

public class RailVehicle : IMovable
{
    public float speed = 30f;

    public virtual void GoForward()
    {
        // Implementation specific to rail vehicles
    }

    public virtual void GoBackward()
    {
        // Implementation specific to rail vehicles
    }
}

public class Car : RoadVehicle
{
    //...
}

public class Truck : RoadVehicle
{
    //...
}

public class Train : RailVehicle
{
    //...
}

public class Tram : RailVehicle
{
    //...
}

```

## Conclusion

By adhering to the Liskov Substitution Principle, as demonstrated in the good design example, derived classes are able to seamlessly substitute their base classes, ensuring correct behavior and maintainability.
