using EmployeesAPI.Models;

namespace EmployeesAPI.Helpers
{
    public class EmployeeHelper
    {
        const int MAX_PAGE_NUM = 1000;
        const int MIN_PAGE_NUM = 0;
        const int MAX_PAGE_SIZE = 1000;
        const int MIN_PAGE_SIZE = 1;

        public List<Employee> FilterEmployeesByDepartment(string department, List<Employee> employees)
        {
            return employees.Where(o => o.Department == department.ToLower()).ToList();  // filter by department
        }

        public List<Employee> PageEmployees(List<Employee> employees, int pageNum, int pageSize)
        {
            return employees	// paging list of Employees based on provided parameters
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public String? ValidateDepartment(string department)
        {
            if (String.IsNullOrEmpty(department)) { return "Null department provided- "; }

            return null;
        }

        public String? ValidatePageNumber(int pageNum)
        {
            if (pageNum < MIN_PAGE_NUM) { return "Page number provided less than 0- "; }

            if (pageNum > MAX_PAGE_NUM) { return "Page number exceeded the maximum limit- "; }

            return null;
        }

        public String? ValidatePageSize(int pageSize)
        {
            if (pageSize < MIN_PAGE_SIZE) { return "Page size provided less than 1- "; }

            if (pageSize > MAX_PAGE_SIZE) { return "Page size exceeded the maximum limit- "; }

            return null;
        }
    }
}

