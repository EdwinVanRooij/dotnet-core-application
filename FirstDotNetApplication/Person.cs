using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication
{
    class Person
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public new string ToString
        {
            get
            {
                return $"{Name}, {Age}";
            }
        }
    }
}
