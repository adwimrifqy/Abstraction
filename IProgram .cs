using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using abstraction.Interface;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            IHewan hewan;

            hewan = new Jerapah();
            hewan.berwarna();

            Console.WriteLine();
            hewan = new Harimau();
            hewan.berwarna();

            Console.ReadKey();
        }
    }
}
