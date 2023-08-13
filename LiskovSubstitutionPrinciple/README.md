# Liskov Substitution Principle

The Liskov Substitution Principle (LSP) states that objects of a derived class must be substitutable for objects of the base class without affecting the correctness of the program. In other words, if a program is using an instance of a base class, it should be able to replace it with an instance of a derived class without causing any unexpected behavior.

## Applying Liskov Substitution Principle

Consider the example of road and rail vehicles that implement the IMovable and ITurnable interfaces. In a well-designed implementation, the Car and Truck classes are derived from the RoadVehicle class, and the Train and Tram classes are derived from the RailVehicle class.


## Bad Design

In the bad design, the `Train` class does not fully adhere to the `ITurnable` interface as required by LSP. This violates the principle, as replacing an instance of the `RailVehicle` base class with an instance of the `Train` derived class might lead to unexpected behavior in scenarios where turning is involved.

```C#
public class Train : RailVehicle
{   
    // No need for TurnLeft and TurnRight on the train
}
```

## Good Design

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
