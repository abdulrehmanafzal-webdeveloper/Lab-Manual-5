using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1
{
    internal class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public double Salary;
        public string Department;

        public Employee(int employeeID=0, string firstName=" ", string lastName = " ", DateTime dateOfBirth=default, double salary=0, string department = " ")
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Salary = salary;
            Department = department;
        }

    }
}
