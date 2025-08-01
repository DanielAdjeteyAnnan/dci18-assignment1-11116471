using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option (1-2): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    Console.WriteLine("Exiting... Peace out ✌🏾");
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
