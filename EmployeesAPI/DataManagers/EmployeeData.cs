using System;
using Microsoft.Data.SqlClient;
using EmployeesAPI.Models;

namespace EmployeesAPI.DataManagers
{ 
    public class EmployeeData
    {
        public List<Employee> employeeList = new();

        public List<Employee> RetrieveEmployeesByDepartment(string department)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("TOP SECRET"))
                {
                    String sql = "SELECT EmployeeId, Name, Designation, Department FROM Employees WHERE Department ='" + department + "'";

                    using (SqlCommand command = new(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employeeList.Add(new Employee(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                            }
                            return employeeList;
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            return employeeList;
        }
    }
}


