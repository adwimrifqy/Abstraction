using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using abstraction.AbstractClass;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan;

            hewan = new Jerapah();
            hewan.berwarna();

            Console.WriteLine();
            hewan = new Harimau();
            hewan.berwarna();

            Console.ReadKey();
        }
    }
}
