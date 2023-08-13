# Dependency Inversion Principle

The Dependency Inversion Principle (DIP) states that high-level modules should not depend on low-level modules. Both should depend on abstractions. Additionally, abstractions should not depend on details; details should depend on abstractions. In other words, this principle promotes the use of interfaces or abstract classes to decouple higher-level components from lower-level implementation details, allowing for flexibility, modularity, and easier maintenance.

## Applying Dependency Inversion Principle
Consider the example of a switch controlling different devices.

## Bad Design

In the bad design, the `Switch` class tightly depends on concrete implementations (`LightBulb`). This leads to a high level of coupling and limits the flexibility of the `Switch` class to work only with specific devices.

```C#
class LightBulb
{
    public void TurnOn()
    {
        Console.WriteLine("LightBulb is ON");
    }
}

class Switch
{
    private LightBulb bulb;

    public Switch()
    {
        bulb = new LightBulb();
    }

    public void Operate()
    {
        bulb.TurnOn();
    }
}

```

## Good Design

In the good design, the `Switch` class relies on abstractions (`ISwitchable` interface) rather than concrete implementations (`LightBulb`, `Door`). By adhering to the Dependency Inversion Principle, the `Switch` class is loosely coupled with various devices that implement the `ISwitchable` interface.


```C#
public interface ISwitchable
{
    bool IsActivated { get; }
    void Activate();
    void Deactivate();
}

class LightBulb : ISwitchable
{
    private bool isActivated;
    public bool IsActivated { get => isActivated; }

    public void Activate()
    {
        isActivated = true;
        Console.WriteLine("LightBulb is On");
    }

    public void Deactivate()
    {
        isActivated = false;
        Console.WriteLine("LightBulb is Off");
    }
}

class Door : ISwitchable
{
    private bool isActivated;
    public bool IsActivated
    {
        get { return isActivated; }
    }
    public void Activate()
    {
        Console.WriteLine("Door is Open");
    }

    public void Deactivate()
    {
        Console.WriteLine("Door is Close");
    }
}

class Switch
{
    private ISwitchable device;

    public Switch(ISwitchable device)
    {
        this.device = device;
    }

    public void Operate()
    {
        if (device.IsActivated)
            device.Deactivate();
        else
            device.Activate();
    }
}

```

## Conclusion

By adhering to the Dependency Inversion Principle as demonstrated in the good design example, the `Switch` class becomes more versatile and adaptable, allowing it to interact with various devices through the common `ISwitchable` interface.
