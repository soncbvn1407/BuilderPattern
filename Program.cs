using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director b = new Director();
            b.Construct();
        }

    }
}
