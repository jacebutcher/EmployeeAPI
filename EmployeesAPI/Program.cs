using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Employee API",
        Description = "A Web API created with ASP.NET to help you manage your employees. \r\n" +
        "List of departments for test usage: finance, operations, security, production, executives.",
        Contact = new OpenApiContact
        {
            Name = "Contact the Developer",
            Url = new Uri("https://www.linkedin.com/in/jacedylanbutcher/")
        },

    });
});

var app = builder.Build();

// TODO: uncomment the below lines to only produce Swagger UI for development
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

