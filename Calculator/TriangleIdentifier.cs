using System;

public class TriangleIdentifier
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter side 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            int c = int.Parse(Console.ReadLine());

            // Check for positive side lengths
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("All sides must be positive numbers.");

            // Triangle inequality check
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Invalid triangle. The sum of any two sides must be greater than the third side.");
                return;
            }

            // Determine type of triangle
            if (a == b && b == c)
                Console.WriteLine("Equilateral Triangle: All three sides are equal.");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles Triangle: Two sides are equal.");
            else
                Console.WriteLine("Scalene Triangle: No sides are equal.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}