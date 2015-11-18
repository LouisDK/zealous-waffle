using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int[] myNumbers = new int[x];

            //myNumbers[0] = 21;
            //myNumbers[1] = 22;
            //myNumbers[2] = 23;
            //myNumbers[3] = 24;
            //myNumbers[4] = 25;

            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            var myNumbers = new List<int>() ;

            for (int j = 0; j < 10; j++)
            {
                myNumbers.Add(j);
            }

            myStopwatch.Stop();
            int test = -5;

            //Console.WriteLine("There is now " + myNumbers.Count + " items in my list");

            //Console.WriteLine("   time taken: " + myStopwatch.Elapsed.Milliseconds);

            //myNumbers.Remove(55);
            //myNumbers.RemoveAt(1);
            //myNumbers.Insert(3, 77);

            //Console.WriteLine("Here we see the For loop:");
            //for (int i = 0; i < myNumbers.Count; i++)
            //{
            //    Console.WriteLine("Current iteration: " + i + ". Current Value of Array at that position: " + myNumbers[i]);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Here we see the Foreach loop:");

            //foreach (var myNumber in myNumbers)
            //{
            //    Console.WriteLine("Current value is: " + myNumber);
            //}

          


            var People = new List<Person>();

            People.Add(new Person() { Firstname = "Louis", Lastname = "De Klerk", Age = 39, Email = "Louis@inobits.com", ManagerEmail = "Hud@inobits.com" });
            People.Add(new Person() { Firstname = "John", Lastname = "Barsby", Age = 62, Email = "John@inobits.com", ManagerEmail = "Hud@inobits.com" });
            People.Add(new Person() { Firstname = "Hud", Lastname = "Krause", Age = 45, Email = "Hud@inobits.com" });

            var CurrentPerson = People.First();
            var CurrentManager = People.Where(q => q.Email == CurrentPerson.ManagerEmail).First();

            Console.WriteLine(" current person " + CurrentPerson.ToString() + " 's manager is " + CurrentManager.ToString());

            Console.ReadLine();



        }
    }

    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        public string ManagerEmail { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " (" + Email + ")";
        }
    }




}
