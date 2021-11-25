using System;
using System.Collections.Generic;

namespace DelegateRealTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Experience = 5,
                Salary = 10000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Experience = 10,
                Salary = 20000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Experience = 15,
                Salary = 30000
            };

            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3 };

            //SIMPLE
            var theDelegate = new EmployeeDelegates.EligibleForPromotionDelegate(Program.Promote);
            Employee.PromoteEmployee(employees, theDelegate);

            //USING LAMBDA EXPRESSIONS
            Employee.PromoteEmployee(employees, employee => employee.Experience > 5);

            Console.WriteLine("\n");
            Console.WriteLine("Enter age to check if adult?");
            int age = int.Parse(Console.ReadLine());

            Predicate<int> checkAgePredicate = new Predicate<int>(CheckIfAdult);

            Console.WriteLine(checkAgePredicate(age) ? "Is an adult." : "Still a teen");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        #region PredicateMethods

        public static bool Promote(Employee employee) => employee.Salary > 10000 ? true : false;

        public static bool CheckIfAdult(int age) => age > 18 ? true : false;

        #endregion

    }
}
