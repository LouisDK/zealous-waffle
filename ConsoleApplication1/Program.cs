using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Process[] listofProcesses = null;
            listofProcesses = System.Diagnostics.Process.GetProcesses();

            foreach (var item in listofProcesses)
            {
                Console.WriteLine(item);
                
            }

            Console.ReadLine();

        }
    }
}
