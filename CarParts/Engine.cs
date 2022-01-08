using System;

namespace BuilderPattern
{
    public class Engine
    {
        public string Name { get; set; }

        public Engine(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of Engine: " + Name);
        }
    }
}