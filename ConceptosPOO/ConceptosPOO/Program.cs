using System;
using System.Collections.Generic;

namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO concepts!");
            Console.WriteLine("=============");

            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "Ana",
                LastName = "Morales",
                BirthDate = new Date(2, 12, 2000),
                HireDate = new Date(15, 6,2019),
                IsActive = true,
                Salary = 1563.121M
            };

            //Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Antonio",
                LastName = "Sanchez",
                BirthDate = new Date(15, 6, 1997),
                HireDate = new Date(15, 6, 2020),
                IsActive = true,
                Sales = 2520121M,
                CommissionPercentaje = 0.03F
            };

            //Console.WriteLine(employee2);

            Employee employee3 = new HourlyEmployee()
            {
                Id = 3030,
                FirstName = "Alex",
                LastName = "Gonzales",
                BirthDate = new Date(15, 6, 1997),
                HireDate = new Date(15, 6, 2020),
                IsActive = true,
                HourValue = 2520.56M,
                Hours = 123.5F
            };

            //Console.WriteLine(employee3);

            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 4024,
                FirstName = "Analy",
                LastName = "Reyes",
                BirthDate = new Date(10, 6, 1992),
                HireDate = new Date(20, 6, 2020),
                IsActive = true,
                Base = 2520.56M,
                Sales = 500023M,
                CommissionPercentaje = 0.0125F
               
            };

            //Console.WriteLine(employee4);

            ICollection<Employee> employees = new List<Employee>()
            {
                employee1, employee2, employee3, employee4
            };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }


            Console.WriteLine("                              ===================");
            Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");


            Invoice invoice1 = new Invoice()
            {
                Description = "inphone 13",
                Id = 1,
                Price = 10032M,
                Quantity = 6

            };

            Invoice invoice2 = new Invoice()
            {
                Description = "Posta Preum",
                Id = 2,
                Price = 20032M,
                Quantity = 17.5F

            };

            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
        }

        
    }
}
