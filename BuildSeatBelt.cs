using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class BuildSeatBelt : ICarBuilder 
    {
        
        private string brand;
        public string Brand { get; set; }
        public override void BuildParts()
        {
            Console.Write("Enter Brand of SeatBelt: ");
            brand = Console.ReadLine();
        }

        public SeatBelt AddSeatBelt()
        {
            Console.WriteLine("Build SeatBelt {0} Success", brand);
            return new SeatBelt(brand);
        }
    }
}