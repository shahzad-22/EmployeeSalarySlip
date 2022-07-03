using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmployeeSalary
{    
  public  class Engineer  
    {
      public double Basic = 1500;
      public void EngineerSalary()
        {
            Console.WriteLine("Thank you for the select to  Engineer");
            double fuel = 100;
            double medical = 500;
            double salary = Basic + fuel + medical;
            Console.WriteLine("your total salary is = " + salary);
            Console.ReadKey();

        }
    }
}
