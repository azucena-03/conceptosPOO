using System;

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

            Console.WriteLine(employee1);

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

            Console.WriteLine(employee2);

        }
    }
}
