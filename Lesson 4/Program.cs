using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 50;
            int B = 5;

            Console.WriteLine("Enter a number...");

            try
            {
 
               B = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not interpret your input as a number!");
                Console.ReadLine();
                Environment.Exit(1);
            }
            

            int Answer = -1;

            try
            {
                Answer = A / B;
                Console.WriteLine("The answer is: " + Answer.ToString());
            }
            catch (DivideByZeroException divZeroProblem)
            {

                System.Diagnostics.EventLog.WriteEntry("ReccoApp","Cannot divide by zero... learn math!!", System.Diagnostics.EventLogEntryType.Error);
                
                Console.WriteLine("Cannot divide by zero... learn math!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops... unexpected error!  Details: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finished with the calculation");
            }

            Console.ReadLine();

        }
    }
}
