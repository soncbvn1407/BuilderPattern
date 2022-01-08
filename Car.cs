using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Car
    {
        public int NumberOfWheels { get; set; }

        public string Color { get; set; }

        public Engine Engine { get; set; }

        public SeatBelt SeatBelt { get; set; }

        public Windscreen Windscreen { get; set; }


        public Car(int numberOfWheels, string color, Engine engine, SeatBelt seatBelt, Windscreen windscreen)
        {
            NumberOfWheels = numberOfWheels;
            SeatBelt = seatBelt;
            Color = color;
            Windscreen = windscreen;
            Engine = engine;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine("Information of Car:");
            Engine.ShowInfo();
            Windscreen.ShowInfo();
            SeatBelt.ShowInfo();
            Console.WriteLine("Color of Car: " + Color);
            Console.WriteLine("NumberOfWheel of Car: " + NumberOfWheels);

        }
        
    }

}