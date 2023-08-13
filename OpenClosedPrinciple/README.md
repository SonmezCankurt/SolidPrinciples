# Open/Closed Principle

The Open/Closed Principle (OCP) states that software entities should be open for extension but closed for modification. This principle encourages designing classes and modules in a way that allows for adding new functionalities without altering existing code. This promotes code reuse, reduces the risk of introducing bugs, and enhances the maintainability of the codebase.

## Applying Open/Closed Principle

Consider the example of an area calculator for shapes. In a well-designed implementation, shapes such as rectangles and circles adhere to the Shape abstract class, allowing new shapes to be easily added without altering existing code.

## Bad Design

In the bad design, the `AreaCalculator` class directly calculates areas for specific shapes (`Rectangle` and `Circle`). This violates the OCP since adding new shapes would require modifying the existing `AreaCalculator` class.

 ```C#
public class AreaCalculator
{
    public double GetRectangleArea(Rectangle rectangle)
    {
        return rectangle.Width * rectangle.Height;
    }

    public double GetCircleArea(Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }
}
 ```

## Good Design

In the good design, the `Shape` abstract class defines the `CalculateArea` method, which is overridden by concrete shape classes such as `Rectangle` and `Circle`. The `AreaCalculator` class operates on shapes using the abstract `Shape` type, enabling easy extension by adding new shape classes.

 ```C#
public abstract class Shape
{
    public abstract double CalculateArea();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class AreaCalculator
{
    public double GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}

 ```

## Conclusion

By adhering to the OCP, as demonstrated in the good design example, new shapes can be seamlessly added without modifying existing code. This ensures a more extensible and maintainable codebase.
