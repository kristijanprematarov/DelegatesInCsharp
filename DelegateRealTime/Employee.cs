using System;
using System.Collections.Generic;

namespace DelegateRealTime
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> employees,
            EmployeeDelegates.EligibleForPromotionDelegate IsEmployeeEligible)
        {
            foreach (Employee employee in employees)
            {
                if (IsEmployeeEligible(employee))
                {
                    Console.WriteLine("Employee {0} Promoted", employee.Name);
                }
            }
        }
    }
}
