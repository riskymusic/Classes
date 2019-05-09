using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class program
    {
        static void Main(string[] args)
        {
            animal animal1 = new animal("lion","cat");
            animal1.Name = "Lion";
            animal1.Type = "Cat";
           
            Console.WriteLine("Animal Type: {0}\nName: {1}\nId: {2}", animal1.Type, animal1.Name, animal1.Id);
        }

    }
    class animal
    {
         string name;
         string type;
         int id;
        //getters and setters 
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public int Id { get { return id; } set { id = value; } }
        //method 
        private int RandomId()
        {
            Random rand = new Random();
            return rand.Next(1000, 9999);
        }
        public animal(string _type, string _name)
        //constructor a type of method with the same name as the class that is used at the time of an objects creation
        {
            Console.WriteLine("New Animal Object Created......");
           
            Type = _type;
            Name = _name;
            Id = RandomId();

        }

    
    }

}
