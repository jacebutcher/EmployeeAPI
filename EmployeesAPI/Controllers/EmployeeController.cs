using EmployeesAPI.Models;
using EmployeesAPI.Managers;
using EmployeesAPI.DataManagers;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAPI.Controllers;

[ApiController]
[Route("employee")]
public class EmployeeController : ControllerBase
{

    private readonly ILogger<EmployeeController> _logger;
    private readonly EmployeeManager manager = new();

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetEmployeesByDepartment")]
    public IActionResult Get(string department, int pageNumber, int pageSize)
    {
        return manager.GetEmployees(department, pageNumber, pageSize);
    }

    // TODO: Add "AddEmployee" method

    // TODO: Add "UpdateEmployee" method

    // TODO: Add "DeleteEmployee" method
}
