using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface
{
    public class Harimau : IHewan
    {
        public void berwarna()
        {
            Console.WriteLine("Harimau berwarna oranye atau putih");
            Console.WriteLine("Kesukaan Harimau adalah daging");
        }
    }
}
