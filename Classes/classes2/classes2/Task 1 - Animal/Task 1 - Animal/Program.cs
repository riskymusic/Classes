using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1___Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            //written questions 
            Console.Write("Please enter the animals type ie. Cow, Chicken, Duck: ");
            string animalType = Console.ReadLine();
            Console.Write("Please enter the sound the animal makes: ");
            string animalSound = Console.ReadLine();
            Animal animal1 = new Animal(animalType, animalSound);
            Console.WriteLine(animal1.AnimalSays());
        }
        class Animal
        {
            //Properties for the animals name and sound Attributes//
            string name;
            string sound;
            //Getters & Setters 
            public string Name { get { return name; } set { name = value; } }
            public string Sound { get { return sound; } set { sound = value; } }

            public Animal(string _name, string _sound)
            {
                //constructor 
                Name = _name;
                Sound = _sound;
            }
            public string AnimalSays()
                //Method 
            {
                return "I love it when the " + Name + " makes that " + Sound + " sound";
            }






        }
    }
}
