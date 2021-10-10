using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private Car car;

        public Person(string name, Car car)
        {
            this.name = name;
            this.car = car;
        }

        public string Name { get => name; set => name = value; }
        public Car Car { get => car; set => car = value; }
    }
}
