using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2
{
    class program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Tesla";
            car1.Model = "Model Y";
            car1.Colour = "red";
            car1.Rego = "ABC123";

            Console.WriteLine($"Car details: \nMake: {car1.Make}\nModel: {car1.Model}\nColour: {car1.Colour}\nRego: {car1.Rego}");
        }
    }

    class Car
    { 
        //Attributes//
        private string model;
        private string make;
        private string rego;
        private string colour;
        //Getters and Setters//
        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public string Rego { get { return rego; } set { rego = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
    }
}


