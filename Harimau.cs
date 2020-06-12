using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstraction.AbstractClass
{
    public class Harimau : Hewan
    {
        public override void berwarna()
        {
            Console.WriteLine("Harimau berwarna oranye atau putih");
            Console.WriteLine("Kesukaan Harimau adalah daging");
        }
    }
}
