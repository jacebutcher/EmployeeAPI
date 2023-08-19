using EmployeesAPI.Models;
using EmployeesAPI.Managers;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAPI.Controllers;

[ApiController]
[Route("employee")]
public class EmployeeController : ControllerBase
{

    private readonly ILogger<EmployeeController> _logger;
    private readonly EmployeeManager manager = new();
    private String? validationError;
    private List<EmployeeResponse> employeeResponse = new();
    private List<Employee> employees = new();

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetEmployeesByDepartment")]
    public IActionResult Get(string department, int pageNumber, int pageSize)
    {
        // validate inputs
        validationError = manager.ValidateParameters(department, pageNumber, pageSize);
        if (!String.IsNullOrEmpty(validationError)) { return BadRequest("Error: " + validationError); } // return validation error (if there is one)

        // retrieve employee list filtered by department
        employees = manager.GetEmployeesByDepartment(department);
        if (employees.Count == 0) { return BadRequest("Error: Department not found."); } // return error response if department not found

        // page employees
        employees = manager.PageFilteredEmployees(employees, pageNumber, pageSize);
        if (employees.Count == 0)
        {
            return BadRequest("Error: Pagination parameters provided too large.");  // department found but pagination provided too large
        }
        else
        {
            employeeResponse = manager.ConvertToResponse(employees);
            return Ok(employeeResponse);   // successful response
        }
    }

    // TODO: Add "AddEmployee" method

    // TODO: Add "UpdateEmployee" method

    // TODO: Add "DeleteEmployee" method
}
