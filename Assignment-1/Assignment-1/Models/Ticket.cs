namespace Assignment_1.Models
{
    public class Ticket
    {
        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }

        private double _price;

        //// Public property to read the price, but keep setting it internal/private
        //public double Price => _price;

        public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            _price = price;
        }

        // Constructor Chaning
        public Ticket(string movieName)
            : this(movieName, TicketType.Standard, new SeatLocation('A', 1), 50.0)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            // taxPercent is a percentage, e.g. 10 for 10%
            return _price + (_price * taxPercent / 100);
        }

        public void ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= _price)
            {
                _price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            double totalPrice = CalcTotal(14); 
            Console.WriteLine("\n====== Ticket Info ======");
            Console.WriteLine($"Movie:    {MovieName}");
            Console.WriteLine($"Type:     {Type}");
            Console.WriteLine($"Seat:     {Seat}");
            Console.WriteLine($"Price:    ${_price:F2}");
            Console.WriteLine($"Total (14% tax):    ${totalPrice:F2}");
            //Console.WriteLine("-----------------------");
        }
    }
}
