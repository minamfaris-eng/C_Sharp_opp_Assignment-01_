using Assignment_1.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Cinema Ticket Booking System!");

        // 1. Testing the Default Ticket Scenario
        Console.Write("Enter movie name for a Quick-Book (Default Ticket): ");
        string standardMovie = Console.ReadLine();

        Ticket defaultTicket = new Ticket(standardMovie);
        defaultTicket.PrintTicket();


        // 2. Testing the Custom Ticket Scenario
        Console.WriteLine("\nNow, let's customize a ticket...");

        Console.Write("Enter movie name: ");
        string movieName = Console.ReadLine();

        Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
        TicketType type = (TicketType)int.Parse(Console.ReadLine());

        Console.Write("Enter Seat Row (A, B, C): ");
        char row = Console.ReadLine()[0];

        Console.Write("Enter Seat Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter Discount: ");
        double discount = double.Parse(Console.ReadLine());

        // Create custom components
        SeatLocation customSeat = new SeatLocation(row, number);
        Ticket customTicket = new Ticket(movieName, type, customSeat, price);

        // Print final summary
        customTicket.PrintTicket();

        Console.WriteLine("\n====== After Discount ======");
        customTicket.ApplyDiscount(discount);
        customTicket.PrintTicket();




        //Console.ReadLine(); 
    }
}