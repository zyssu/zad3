using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public abstract class Animals
    {
        string Name;
        int Age;

        public Animals(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
