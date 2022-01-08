using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Director
    {
        
        private ICarBuilder part;

        private int Getchoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public void Construct()
        {
            Engine engine = null;
            SeatBelt seatBelt = null;
            Windscreen windscreen = null;
            string color = "";
            int wheels = 0;
            bool running = true;
            while (running)
            {
                Menu();
                int choice = Getchoice();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter Color of Car: ");
                            color = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter NumberOfWheels of Car: ");
                            wheels = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            part = new BuildEngine();
                            part.BuildParts();
                            engine =( (BuildEngine)part).AddEngine();
                            break;
                        }
                    case 4:
                        {
                            part = new BuildSeatBelt();
                            part.BuildParts();
                            seatBelt = ( (BuildSeatBelt)part).AddSeatBelt();
                            break;
                        }
                    case 5:
                        {
                            part = new BuildWindscreen();
                            part.BuildParts();
                            windscreen = ( (BuildWindscreen)part).AddWindscreen();
                            break;
                        }
                    case 6:
                        {
                            Car car = GetCar(wheels, color, engine, seatBelt, windscreen);
                            car.ShowInfo();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Exit");
                            running = false;
                            break;
                        }
                    default: Console.WriteLine("Invalid choice!"); break;
                }
            }
        }

        private void Menu()
        {
            System.Console.WriteLine("Menu");
            System.Console.WriteLine("1. Enter Color");
            System.Console.WriteLine("2. Enter NumberOfWheels");
            System.Console.WriteLine("3. Enter Engine");
            System.Console.WriteLine("4. Enter SeatBelt");
            System.Console.WriteLine("5. Enter Windscreen");
            System.Console.WriteLine("6. Show Car");
            System.Console.WriteLine("0. Exit.");
        }

        private Car GetCar(int wheels, string color, Engine e, SeatBelt s, Windscreen w)
        {
            if (color != "" && wheels != 0 && e != null && s != null && w != null)
            {
                Car car = new Car(wheels, color, e, s, w);
                Console.WriteLine("Build car Succesful");
                return car;
            }
            else Console.WriteLine("Not enough parts to build a car"); return null;
            
        }
    }
}