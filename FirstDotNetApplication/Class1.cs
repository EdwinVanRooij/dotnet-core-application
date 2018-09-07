using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication
{
    class Cat
    {
        public void MakeSound()
        {
            Console.WriteLine("Purrrrr");
        }
    }

    class Lion : Cat
    {
        public new void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }
}
