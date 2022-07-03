using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmployeeSalary
{
   public class Analysts  
    {

       public double Basic = 1500;
       double fuel = 150;
       double medical = 800;
       public  void AnalystsSalary()
        {
            Console.WriteLine("you for the select to  Analysts");
           
            double salary = Basic + fuel + medical;
            Console.WriteLine("your total salary is = " + salary);
            Console.ReadKey();

        }
    }
}
