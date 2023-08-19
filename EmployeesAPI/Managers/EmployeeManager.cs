﻿using System.Linq;
using EmployeesAPI.Helpers;
using EmployeesAPI.DataManagers;
using EmployeesAPI.Models;

namespace EmployeesAPI.Managers
{
    public class EmployeeManager
    {
        private readonly EmployeeHelper helper = new();
        private readonly EmployeeDataManager dataManager = new();
        private List<EmployeeResponse> employeeResponse = new();

        public String? ValidateParameters(string department, int pageNumber, int pageSize)
        {
            String? validationError = helper.ValidateDepartment(department);
            validationError += helper.ValidatePageNumber(pageNumber);
            validationError += helper.ValidatePageSize(pageSize);

            return validationError;
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            List<Employee> employees = dataManager.GetAllEmployees();
            return helper.FilterEmployeesByDepartment(department, employees);
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
