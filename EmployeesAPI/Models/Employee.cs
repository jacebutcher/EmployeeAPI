using System;

namespace EmployeesAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }

        public Employee(int employeeId, string name, string designation, string department)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Designation = designation;
            this.Department = department;
        }
    }
}

