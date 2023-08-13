# Single Responsibility Principle

The Single Responsibility Principle (SRP) states that a class should have only one reason to change. In other words, a class should have a single responsibility. This principle encourages creating classes that are focused on a specific task, ensuring a clear and maintainable codebase.


Consider the example of generating student reports. In a well-designed implementation, the responsibilities of creating student objects, calculating average grades, and generating reports are separated into distinct classes.


## Good Design

In the good design, the Student class is responsible for storing student information, the GradeCalculator class calculates average grades, and the ReportGenerator class generates reports based on student data. Each class has a single, well-defined responsibility.


## Bad Design

In the bad design, the Student class has multiple responsibilities: storing student information, calculating average grades, and generating reports. This violates the SRP by bundling different responsibilities within a single class.

By adhering to the SRP, as demonstrated in the good design example, classes become more focused, easier to understand, and changes in one area have minimal impact on other areas. This results in a more maintainable and scalable codebase.
