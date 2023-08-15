# Single Responsibility Principle

The Single Responsibility Principle (SRP) states that a class should have only one reason to change. In other words, a class should have a single responsibility. This principle encourages creating classes that are focused on a specific task, ensuring a clear and maintainable codebase.

## Applying Single Responsibility Principle

Consider the example of generating student reports. In a well-designed implementation, the responsibilities of creating student objects, calculating average grades, and generating reports are separated into distinct classes.


## Bad Design

In the bad design, the  `Student` class has multiple responsibilities: storing student information, calculating average grades, and generating reports. This violates the SRP by bundling different responsibilities within a single class.

 ```C#
class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public double CalculateAverageGrade()
    {
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Count;
    }

    public void GenerateReport()
    {
        double average = CalculateAverageGrade();
        Console.WriteLine($"Student: {Name}");
        Console.WriteLine($"Average Grade: {average}");
        if (average >= 70)
        {
            Console.WriteLine("Status: Passed");
        }
        else
        {
            Console.WriteLine("Status: Failed");
        }
    }
}
 ```


## Good Design

In the good design, the `Student` class is responsible for storing student information, the `GradeCalculator` class calculates average grades, and the `ReportGenerator` class generates reports based on student data. Each class has a single, well-defined responsibility.

 ```C#
class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, List<int> grades)
    {
        Name = name;
        Grades = grades;
    }
}

class GradeCalculator
{
    public double CalculateAverageGrade(List<int> grades)
    {
        double sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return sum / grades.Count;
    }
}

class ReportGenerator
{
    public void GenerateReport(string studentName, double averageGrade)
    {
        Console.WriteLine($"Student: {studentName}");
        Console.WriteLine($"Average Grade: {averageGrade}");
        if (averageGrade >= 70)
        {
            Console.WriteLine("Status: Passed");
        }
        else
        {
            Console.WriteLine("Status: Failed");
        }
    }
}
 ```

## Conclusion

By adhering to the SRP, as demonstrated in the good design example, classes become more focused, easier to understand, and changes in one area have minimal impact on other areas. This results in a more maintainable and scalable codebase.

However, remember that each principle may have its disadvantage when taken to extremes. Overly divided classes can result in numerous small classes and unnecessary complexity, which might reduce code readability.
