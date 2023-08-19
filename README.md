# Employee REST API

This API currently supports retrieving a list of all employees filtered by their respective departments. The Database used is a SQL Server/DB hosted on Azure along with the API.

## Usage

You can navigate to the following link to use the API along with the Swagger UI for simpler testing: [Swagger API Usage](https://jacescoolapi.azurewebsites.net/swagger/index.html) 

OR you can manually test the API's function with URL parameters like so: https://jacescoolapi.azurewebsites.net/employee?department=security&pageNumber=1&pageSize=10

## Example
https://github.com/jacebutcher/EmployeeAPI/assets/114118425/88149b27-5132-4e6f-9186-5acb10dfda43


## Notes

If you provide a department that does not exist, you should receive a corresponding error message.
These are the following departments that you can test with:
-finance
-operations
-security
-production
-executives

### Contact the Developer

[Jace Butcher](https://www.linkedin.com/in/jacedylanbutcher/)
