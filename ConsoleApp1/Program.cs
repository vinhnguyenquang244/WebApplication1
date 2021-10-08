using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        int id;
        string name;

        public Product()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[] {
                    new Person("terry", Car.Cars[0]),
            new Person("lampard", Car.Cars[1]),
            new Person("aff", Car.Cars[2])
        };
            var query = from car in Car.Cars
                        join person in persons on car.Id equals person.Car.Id into cp
                        from per in cp.DefaultIfEmpty(new Person("noName", new Car()))
                        select new{car = car, person = cp, nameOwner = per.Name };
            foreach(var car in query)
            {
                Console.WriteLine(car.car);
                Console.WriteLine(car.nameOwner);
                foreach (var person in car.person)
                {
                    Console.WriteLine(person.Name);
                }    
            }
        }
    }
}
