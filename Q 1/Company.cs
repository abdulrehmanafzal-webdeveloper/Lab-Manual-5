using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class Company
    {
        string CompanyName;
        Employee[] Employees;
        int count;
        public Company()
        {
            CompanyName = "Uber";
            Employees = new Employee[50];
            count = 0;
        }
        public void addemployee(Employee employee)
        {
            Employees[count] = employee;  
            count++;
        }

        public void removeemployee(int employeeid)
        {
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                if (Employees[i].EmployeeID == employeeid)
                {
                    found = true;
                    Employees[i] = Employees[i + 1];
                    Console.WriteLine("employee is removed");
                }
            }
            if (found == true)
            {
                count--;
            }
            else
            {
                Console.WriteLine($"employee ID: {employeeid} is not found\n");
            }
        }

        public void  displaydetail(int employeeid)
        {
            for (int i = 0; i < count; i++)
            {
                if (Employees[i].EmployeeID == employeeid)
                {
                    Console.WriteLine($"ID: {Employees[i].EmployeeID}");
                    Console.WriteLine($"Name: {Employees[i].FirstName} {Employees[i].LastName}");
                    Console.WriteLine($"Date of Birth: {Employees[i].DateOfBirth.ToShortDateString()}");
                    Console.WriteLine($"Salary: ${Employees[i].Salary}");
                    Console.WriteLine($"Department: {Employees[i].Department}");
                    Console.WriteLine("---------------------------");
                }
            }
        }
    }
}
