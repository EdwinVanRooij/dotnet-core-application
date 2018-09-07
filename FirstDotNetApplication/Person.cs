using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApplication
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public new string ToString
        {
            get {
                return Name;
                    }
        }
    }
}
