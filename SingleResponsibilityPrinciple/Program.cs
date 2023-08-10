using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jack", new List<int> { 50, 90, 70, 80 });
            Student student2 = new Student("Tom", new List<int> { 45, 55, 90, 60 });


            ReportGenerator reportGenerator = new ReportGenerator();
            reportGenerator.GenerateReport(student.Name, new GradeCalculator().CalculateAverageGrade(student.Grades));
            Console.WriteLine("----------");
            reportGenerator.GenerateReport(student2.Name, new GradeCalculator().CalculateAverageGrade(student2.Grades));

            Console.ReadLine();
        }
    }

    // Good Design

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

/*

    // Bad Design
  
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
    }*/
}
