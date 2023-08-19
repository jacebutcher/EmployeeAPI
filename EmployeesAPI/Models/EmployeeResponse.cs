using System;

namespace EmployeesAPI.Models
{
    public class EmployeeResponse
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public EmployeeResponse(int EmployeeId, string Name, string Designation)
        {
            this.EmployeeId = EmployeeId;
            this.Name = Name;
            this.Designation = Designation;
        }
    }
}

