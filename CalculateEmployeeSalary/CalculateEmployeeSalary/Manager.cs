using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmployeeSalary
{
   public class Manager  
    {
         public double Basic = 1500;
         double fuel = 250;
         double medical = 1000;
         public void ManagerSalary()
        {
            Console.WriteLine("you for the select to  Manager");

            double salary = Basic + fuel + medical;
            Console.WriteLine("your total salary is = " + salary);
            Console.ReadKey();

        }
    }
}
