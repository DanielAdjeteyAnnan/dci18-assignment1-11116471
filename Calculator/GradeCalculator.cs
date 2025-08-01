using System;

public class GradeCalculator
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter your grade (0-100): ");
            int grade = int.Parse(Console.ReadLine());

            if (grade < 0 || grade > 100)
                throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");

            if (grade >= 90) Console.WriteLine("Grade: A");
            else if (grade >= 80) Console.WriteLine("Grade: B");
            else if (grade >= 70) Console.WriteLine("Grade: C");
            else if (grade >= 60) Console.WriteLine("Grade: D");
            else Console.WriteLine("Grade: F");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
