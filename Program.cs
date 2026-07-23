using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{

    class Employee
    {
        public int employeeId;
        public string employeeName;
        public double basicSalary;

        public Employee()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("   Employee Payroll System   ");
            Console.WriteLine("=============================");
        }

        public void AcceptDetails()
        {
            Console.Write("Enter Employee ID: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            employeeName = Console.ReadLine();
            Console.Write("Enter Basic Salary: ");
            basicSalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Basic Salary: " + basicSalary);
        }

        public virtual void CalculateSalary()
        {
            Console.WriteLine("Salary Calculation");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double hra = basicSalary * 0.2;
            double da = basicSalary * 0.1;
            double NetSalary = basicSalary + hra + da;

            Console.WriteLine("=================================");
            Console.WriteLine("Employee type: Full Time Employee");
            Console.WriteLine("Net Salary: " + NetSalary);
        }
    }

    class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            double NetSalary = basicSalary;

            Console.WriteLine("=================================");
            Console.WriteLine("Employee type: Part Time Employee");
            Console.WriteLine("Net Salary: " + NetSalary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of Employee (1 or 2) : ");
            Console.WriteLine("1. FullTime Employee");
            Console.WriteLine("2. PartTime Employee");
            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Employee employee = null;
            if(choice == 1)
            {
                employee = new FullTimeEmployee();
            }else if(choice == 2)
            {
                employee = new PartTimeEmployee();
            }
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            employee.AcceptDetails();
            employee.DisplayDetails();
            employee.CalculateSalary();

            Console.ReadKey();
        }
    }
}
