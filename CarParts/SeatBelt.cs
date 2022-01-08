using System;

namespace BuilderPattern
{
    public class SeatBelt
    {
        public string Brand { get; set; }

        public SeatBelt(string brand)
        {
            Brand = brand;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of SeatBelt: " + Brand);
        }
    }
}