using System;


namespace BuilderPattern
{
    public class BuildEngine : ICarBuilder 
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public Engine Engine { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public Windscreen Windscreen { get; set; }

        private string name;
        public override void BuildParts()
        {
            Console.Write("Enter Name of Engine: ");
            name = Console.ReadLine();
        }

        public Engine AddEngine()
        {
            Console.WriteLine("Build Engine {0} Success", name);
            return new Engine(name);
        }
    }
}