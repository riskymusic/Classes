using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Animals
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Lion";
            animal.Sound = "Rarr";

            Console.WriteLine($"Animal Details: \nName: {animal.Name} \nSound: {animal.Sound}");
        }
    }
    class Animal
    {
        private string name;
        private string sound;

        public string Name { get { return name; } set { name = value; } }
        public string Sound { get { return sound; } set { sound = value; } }
    }
}
