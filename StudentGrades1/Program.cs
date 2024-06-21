
using System;
using StudentGrades1;

internal class Program
{
    public static void Main(string[] args)
    {
        var gradeCalulator = new GradeCalculator();

        Console.Write("Enter the percentage:");
        var percentage = Convert.ToInt32(Console.ReadLine());

        var grade = gradeCalulator.GetGradeByPercentage(percentage);

        Console.WriteLine($"Student Grade : {grade}");
    }
}
