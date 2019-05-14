using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class program //Overall program 
    {
        static void Main(string[] args)
        {
            //Obtain information about the employee and save them to variables
            Console.Write("Please enter in the employees first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter in the employees last name: ");
            string lname = Console.ReadLine();
            Console.Write($"Please enter {fname}'s Tax rate? ");
            double tax = double.Parse(Console.ReadLine());
            Console.Write($"Please enter {fname}'s Gross annual income: ");
            double gross = double.Parse(Console.ReadLine());

            //Create an employee object using the constructor and populating it with the variables where we saved the employees info.
            Employee p1 = new Employee(fname, lname, tax, gross);

            Console.WriteLine($"Net Salary: ${Math.Round(p1.NetSalary(), 2)}");

            Console.WriteLine($"Name: {p1.Fname} {p1.Lname}\nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.NetSalary()}");
            Console.ReadLine();
        }

    }
    class Employee //class 
        {
        //getters and setters 
            public string Fname { get; set; }
            public string Lname { get; set; }
        public double Tax { get; set; } = 15; //hard coding percentage - have to delete everything else under tax
        // or public double Tax { get; set; } = 0.15 (double is used tp reflect answer)
            public double Gross { get; set; }
        //constructor, has the same name and capitilisation as the class name 
            public Employee(string _fname, string _lname, double _tax, double _gross)
            {
                Fname = _fname;
                Lname = _lname;
                Tax = _tax;
                Gross = _gross;
            }
        //Methods to calculate the employees net salary( after tax) 
            public double NetSalary()
            {
                return Gross * (1 - Tax / 100);
            // return Gross * (1 - Tax); - if using double and 0.15 above in the getters and setters 
            }
    }
}      

        
            
        
    

