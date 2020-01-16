using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
     abstract class Fish
     {
        public string name;
        public string weight;
        public Fish()
        {

        }
        public Fish(string name, string weight)
        {
            this.name = name;
            this.weight = weight;
        }

    }
}
