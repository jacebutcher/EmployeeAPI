using EmployeesAPI.Models;

namespace EmployeesAPI.DataManagers
{
    public class EmployeeDataManager
    {
        //TODO: Create a SQL Database with a table called "Employees" to hold the data below, this
        // is a temporary local data-store used to hold Employee data for this minimal API.
        readonly List<Employee> employees = new()
        {
            new Employee(1, "John Adams", "accountant", "finance"),
            new Employee(2, "Tiger Woods", "manager", "operations"),
            new Employee(3, "Steve Rodgers", "body guard", "security"),
            new Employee(4, "Tony Stark", "inventor", "production"),
            new Employee(5, "Bart Simpson", "ceo", "executives"),
            new Employee(6, "Anakin Skywalker", "jr.accountant", "finance"),
            new Employee(7, "Mickey Mouse", "auditor", "operations"),
            new Employee(8, "Peter Parker", "senior body guard", "security"),
            new Employee(9, "Nairobi", "money generator", "production"),
            new Employee(10, "Tokyo", "cfo", "executives"),
            new Employee(11, "Walter White", "accountant", "finance"),
            new Employee(12, "Marty McFly", "manager", "operations"),
            new Employee(13, "Harry Potter", "body guard", "security"),
            new Employee(14, "Charlie Brown", "inventor", "production"),
            new Employee(15, "Micahel Scott", "ceo", "executives"),
            new Employee(16, "Dwight Schrute", "jr.accountant", "finance"),
            new Employee(17, "Ryan Reynolds", "auditor", "operations"),
            new Employee(18, "Brad Pitt", "senior body guard", "security"),
            new Employee(19, "Bruce Willis", "money generator", "production"),
            new Employee(20, "Quentin Tarantino", "cfo", "executives"),
            new Employee(21, "Rick Dalton", "accountant", "finance"),
            new Employee(22, "Cliff Booth", "manager", "operations"),
            new Employee(23, "Bruce Lee", "body guard", "security"),
            new Employee(24, "Conor McGregor", "inventor", "production"),
            new Employee(25, "Steve McQueen", "ceo", "executives"),
            new Employee(26, "Hattori Hanzo", "jr.accountant", "finance"),
            new Employee(27, "Gogo Yubari", "auditor", "operations"),
            new Employee(28, "Terrence Crawford", "senior body guard", "security"),
            new Employee(29, "Floyd Mayweather", "money generator", "production"),
            new Employee(30, "Darth Vader", "cfo", "executives"),
            new Employee(31, "Jim Halpert", "accountant", "finance"),
            new Employee(32, "Pam Halpert", "manager", "operations"),
            new Employee(33, "Zhang Weili", "body guard", "security"),
            new Employee(34, "Valentina Schevchenko", "inventor", "production"),
            new Employee(35, "Brandon Moreno", "ceo", "executives"),
            new Employee(36, "Jon Jones", "jr.accountant", "finance"),
            new Employee(37, "Aljamain Sterling", "auditor", "operations"),
            new Employee(38, "Sean O'Malley", "senior body guard", "security"),
            new Employee(39, "Yair Rodriguez", "money generator", "production"),
            new Employee(40, "Brian Ortega", "cfo", "executives"),
            new Employee(41, "Israel Adesanya", "accountant", "finance"),
            new Employee(42, "Rodtang", "manager", "operations"),
            new Employee(43, "Amanda Nunes", "body guard", "security"),
            new Employee(44, "Stipe Miocic", "inventor", "production"),
            new Employee(45, "Jamahal Hill", "ceo", "executives"),
            new Employee(46, "Marvin Vettori", "jr.accountant", "finance"),
            new Employee(47, "Leon Edwards", "auditor", "operations"),
            new Employee(48, "Khamzat Chimaev", "senior body guard", "security"),
            new Employee(49, "Dustin Poirier", "money generator", "production"),
            new Employee(50, "John John", "cfo", "executives"),
        };

        public List<Employee> GetAllEmployees()
        {
            return employees; // return all employees in the company
        }
    }
}

