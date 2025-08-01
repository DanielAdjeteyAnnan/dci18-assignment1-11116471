using System;

public class TicketCalculator
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 0)
                throw new ArgumentOutOfRangeException("Age cannot be negative.");

            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7");
            else
                Console.WriteLine("Ticket Price: GHC10");
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