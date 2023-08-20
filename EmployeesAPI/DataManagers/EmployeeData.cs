using System;
using Microsoft.Data.SqlClient;
using EmployeesAPI.Models;

namespace EmployeesAPI.DataManagers
{ 
    public class EmployeeData
    {
        public List<Employee> employeeList = new();
        public string? sqlError;

        public List<Employee> RetrieveEmployeesByDepartment(string department)
        {
            try
            {
                using SqlConnection connection = new("TOP SECRET");
                String sql = "SELECT EmployeeId, Name, Designation, Department FROM Employees WHERE Department ='" + department + "'";

                using SqlCommand command = new(sql, connection);
                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // employee properties: EmployeeId, Name, Designation, and Department.
                    employeeList.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
                return employeeList;
            }
            catch (SqlException)
            {
                sqlError = "Error: Connection error logging into the SQL Database. Check your credentials.";    // sql error encountered, return response
            }
            return employeeList;
        }
    }
}


