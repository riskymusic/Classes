using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_persons_class
{
    class Name
    {
        static void Main(string[] args)
        {
            Person Tama = new Person("Tama", "Owens", 28);
            Console.WriteLine("Persons Details");
            Console.WriteLine($"Name: {Tama.Fname} {Tama.Lname}\nAge: {Tama.Age}");
            Console.ReadLine();
        }
    }
    class Person
    {
        //attributes
        string fname;
        string lname;
        int age;
        //Attributes getters and setter (combined make properties)
        public string Fname {  get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }
        //Constructor
        public Person(string _fname, string _lname, int _age)
        {
            Fname = _fname;
            Lname = _lname;
            Age = _age;
        }

    
    }
}
