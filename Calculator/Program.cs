class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Grade Calculator");
            Console.WriteLine("2. Ticket Price Calculator");
            Console.WriteLine("3. Triangle Identifier");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option (1-4): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    GradeCalculator.Run();
                    break;
                case "2":
                    TicketCalculator.Run();
                    break;
                case "3":
                    TriangleIdentifier.Run();
                    break;
                case "4":
                    Console.WriteLine("Exiting... Peace out ✌🏾");
                    return; // This ends the program
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine(); // Pause before showing menu again
            Console.Clear();    // Optional: Clear screen before showing menu again
        }
    }
}
