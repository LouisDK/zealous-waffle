using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            int MyNumber;
            MyNumber = 5;
            
            

            Person MyPersonA;
            MyPersonA = new Person();
            MyPersonA.Firstname = "Louis";
            MyPersonA.Age = 38;
            
            string GreetMessage = MyPersonA.Greet("Mr");
            Console.WriteLine(GreetMessage);


            Employee Lowe;
            Lowe = new Employee();
           

            Customer CustA;
            CustA = new Customer();
            


            Console.WriteLine("Press any key...");
            Console.ReadLine();
        }
    }

    class Employee : Customer
    {
        public int EmployeeNumber { get; set; }
    }

    class Customer : Person
    {
        public int CustomerRefNo { get; set; }

        public string Invoice()
        {
            return "Here is your invoice...";
        }

    }

    class Person
    {
        public string Firstname { get; set; }
        public int Age { get; set; }

        public string Greet(string Title)
        {
            string Result = "Hallo " + Title + " " + Firstname;
            return Result;
        }

        public override string ToString()
        {
            return Firstname + " is now " + Age.ToString() + " old.";
        }

    }


}
