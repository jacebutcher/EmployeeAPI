using EmployeesAPI.Helpers;
using EmployeesAPI.DataManagers;
using EmployeesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAPI.Managers
{
    public class EmployeeManager
    {
        private readonly EmployeeHelper helper = new();
        private readonly EmployeeData data = new();
        private List<EmployeeResponse> employeeResponse = new();
        private String? validationError;
        private List<Employee> employees = new();

        public IActionResult GetEmployees(string department, int pageNumber, int pageSize)
        {
            // validate inputs
            validationError = ValidateParameters(department, pageNumber, pageSize);
            if (!String.IsNullOrEmpty(validationError)) { return new BadRequestObjectResult("Error: " + validationError); } // return validation error (if there is one)

            // retrieve employee list filtered by department
            employees = GetEmployeesByDepartment(department);
            if (!String.IsNullOrEmpty(data.sqlError)) { return new BadRequestObjectResult(data.sqlError); } // SQL error encountered 
            if (employees.Count == 0) { return new BadRequestObjectResult("Error: Department not found."); } // return error response if department not found

            // page employees
            employees = PageFilteredEmployees(employees, pageNumber, pageSize);
            if (employees.Count == 0)
            {
                return new BadRequestObjectResult("Error: Pagination parameters provided too large.");  // department found but pagination provided too large
            }
            else
            {
                employeeResponse = ConvertToResponse(employees);
                return new OkObjectResult(employeeResponse);   // successful response
            }
        }

        public String? ValidateParameters(string department, int pageNumber, int pageSize)
        {
            String? validationError = helper.ValidateDepartment(department);
            validationError += helper.ValidatePageNumber(pageNumber);
            validationError += helper.ValidatePageSize(pageSize);

            return validationError;
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            return data.RetrieveEmployeesByDepartment(department);
        }

        public List<Employee> PageFilteredEmployees(List<Employee> employees, int pageNum, int pageSize)
        {
            return helper.PageEmployees(employees, pageNum, pageSize);
        }

        public List<EmployeeResponse> ConvertToResponse(List<Employee> employees)
        {
            employeeResponse =
                employees.Select(employee => new EmployeeResponse(employee.EmployeeId, employee.Name, employee.Designation)).ToList();

            return employeeResponse;
        }
    }
}

