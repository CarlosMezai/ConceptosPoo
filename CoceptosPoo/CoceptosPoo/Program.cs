using System;
using System.Collections.Generic;

namespace CoceptosPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts!");
            Console.WriteLine("=============");

            Employee employee1 = new SalaryEmployee()
            {
                Id = 1001,
                FirstName = "Silvia",
                LastName = "Meza",
                BirthDate = new Date(1995, 05, 26),
                HiringDate = new Date(2020, 01, 01),
                IsActive = true,
                Salary = 1900000.50M,

            };

            //Console.WriteLine(employee1);

            Employee employee2 = new CommissionEmployee()
            {
                Id = 1002,
                FirstName = "Jairo",
                LastName = "Sierra",
                BirthDate = new Date(1997, 07, 13),
                HiringDate = new Date(2021, 01, 01),
                IsActive = true,
                Sales = 3200000M,
                CommissionPercentaje = 0.03F,

            };

            //Console.WriteLine(employee2);

            Employee employee3 = new HouryEmployee()
            {
                Id = 1003,
                FirstName = "Diego",
                LastName = "Gonzalez",
                BirthDate = new Date(1985, 05, 26),
                HiringDate = new Date(2021, 01, 01),
                IsActive = true,
                HourValue = 40000.50M,
                Hours = 123.5F

            };


            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 1004,
                FirstName = "Yazmin",
                LastName = "Acero",
                BirthDate = new Date(1970, 06, 26),
                HiringDate = new Date(2020, 01, 01),
                IsActive = true,
                Base = 1000000.45M,
                Sales = 40000000M,
                CommissionPercentaje = 0.015F
            };


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
            Console.WriteLine("                               =================");
            Console.WriteLine($"TOTAL                            {$"{payroll:C2}",15}");


            Invoice invoice1 = new Invoice()
            {
                Description = "Cel Xiaomi A10",
                Id = 1,
                Price = 800000M,
                Quantity = 5
            };

            Invoice invoice2 = new Invoice()
            {
                Description = "Samsung A32",
                Id = 2,
                Price = 10000000M,
                Quantity = 7
            };

            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);




            //Console.WriteLine(employee4);
            //Date date1 = new Date(2022, 08, 02);
            //try
            //{
            //    Console.WriteLine(new Date(2024, 2, 29));
            //    Console.WriteLine(new Date(1974, 11, 03));
            //    Console.WriteLine(new Date(1985, 11, 31));
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message);

            //
            //
        }
    }
}
