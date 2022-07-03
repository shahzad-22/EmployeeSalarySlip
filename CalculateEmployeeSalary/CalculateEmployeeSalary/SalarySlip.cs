using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateEmployeeSalary
{
    public class SalarySlip
    {
        
       static void Main(string[] args)
        {
            SalarySlip salaryslip = new SalarySlip();
            Engineer engineer = new Engineer();
            Manager manager = new Manager();
            Analysts analysts = new Analysts();
            int input;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choise the following options");
                Console.WriteLine("1: For Engineer");
                Console.WriteLine("2: For Manager");
                Console.WriteLine("3: For Analysts");
                Console.WriteLine("4: For Exit");
                input = Convert.ToInt32(Console.ReadLine());
                
                
                switch (input) {

                    case 1:  
                       engineer.EngineerSalary();
                        break;
                    case 2:
                        manager.ManagerSalary();
                        break;
                    case 3:
                        analysts.AnalystsSalary();
                        break;
                    case 4:
                       flag=false;
                        break;
                }
                
                }
            }
        }
}
