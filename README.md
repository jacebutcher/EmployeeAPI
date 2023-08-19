# Employee REST API

This API currently supports retrieving a list of all employees filtered by their respective departments.

## Usage

You can navigate to the following link to use the API along with the Swagger UI for simpler testing: [Swagger API Usage](https://jacescoolapi.azurewebsites.net/swagger/index.html) 

OR you can manually test the API's function with URL parameters like so: https://jacescoolapi.azurewebsites.net/employee?department=security&pageNumber=1&pageSize=10

## Notes

If you provide a department that does not exist, you should receive a corresponding error message.
These are the following departments that you can test with:
-finance
-operations
-security
-production
-executives

## TODO

-Setup a SQL Database to hold all of the Employee data. Currently, the data is kept in a data-layer within the project for simplicity and testing purposes. 

### Contact the Developer

[Jace Butcher](https://www.linkedin.com/in/jacedylanbutcher/)