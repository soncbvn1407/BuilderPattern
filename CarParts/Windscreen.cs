using System;

namespace BuilderPattern
{
    public class Windscreen
    {
        public string Name { get; set; }

        public Windscreen(string name)
        {
            Name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name of Windscreen: " + Name);
        }
    }
}