using System;

namespace BuilderPattern
{
    public class BuildWindscreen : ICarBuilder 
    {
        private string name;
        public string Name { get; set; }
        public override void BuildParts()
        {
            Console.Write("Enter Name of Windscreen: ");
            name = Console.ReadLine();
        }

        public Windscreen AddWindscreen()
        {
            Console.WriteLine("Build Windscreen {0} Success", name);
            return new Windscreen(name);
        }
    }
}