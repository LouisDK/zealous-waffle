using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4WithExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            var TheFileName = System.Configuration.ConfigurationManager.AppSettings.GetValues("myFilename").FirstOrDefault();

            var myNewFile = new System.IO.FileInfo(TheFileName);

            var Excel = new OfficeOpenXml.ExcelPackage(myNewFile);

            OfficeOpenXml.ExcelWorksheet myNewSheet;

            try
            {
                myNewSheet = Excel.Workbook.Worksheets.Add("Data");
            }
            catch (Exception)
            {
                myNewSheet = Excel.Workbook.Worksheets["Data"];
            }
            

            myNewSheet.Cells["B1"].Value = "Name";
            myNewSheet.Cells["C1"].Value = "Size";
            myNewSheet.Cells["D1"].Value = "Created";
            myNewSheet.Cells["E1"].Value = "Last modified";
            myNewSheet.Cells["B1:E1"].Style.Font.Bold = true;

            myNewSheet.Cells["B2"].Value = "Louis de Klerk";

            Excel.Save();


            //var myExistingSheet = Excel.Workbook.Worksheets["Data"];

            //Console.WriteLine("Found: " + myExistingSheet.Cells["B2"].Value);

            //var Col = 2;
            //var Row = 2;
            //var CurrentValue = "";
            //var LastRow = 0;

            //for (int i = 1; i < 100000; i++)
            //{
            //    try
            //    {
            //        CurrentValue = myExistingSheet.GetValue(i, Col).ToString();
            //        LastRow = i;
            //    }
            //    catch (Exception)
            //    {
            //        break;
            //    }
            //}



            //for (int i = Row; i < LastRow + 1; i++)
            //{
            //    CurrentValue = myExistingSheet.GetValue(i, Col).ToString();
            //    Console.WriteLine("Found : " + CurrentValue);
            //}


            Console.ReadLine();

            Console.WriteLine("Done!");

        }
    }
}
