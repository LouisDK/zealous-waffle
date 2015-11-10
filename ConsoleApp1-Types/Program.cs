using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            //Decimal NumberA;
            //Decimal NumberB;

            //NumberA = 16;
            //NumberB = 5;

            //Decimal MyResult = NumberA / NumberB;

            //Console.WriteLine("The answer is: " + MyResult);



            //string MyStringNumber;
            //decimal NumberB;
            //decimal Answer;
            //decimal interimNumber;

            //MyStringNumber = "17";
            ////interimNumber = Convert.ToDecimal(MyStringNumber);
            //interimNumber = decimal.Parse(MyStringNumber);
            //NumberB = 5;

            //Answer = interimNumber /  NumberB;

            //Console.WriteLine("The answer is: " + Answer);



            string MyString = "What is your Date of birth?";
            Console.WriteLine(MyString);

            DateTime dob;
            dob = DateTime.Parse(Console.ReadLine());

            TimeSpan Age = DateTime.Now - dob;


            Console.WriteLine("The age is: " + dob);



            Console.ReadLine();
        }
    }
}
