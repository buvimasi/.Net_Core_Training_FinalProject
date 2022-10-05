using Microsoft.EntityFrameworkCore;
using FinalProjectAPI.Data;
using FinalProjectAPI.Helpers;
using FinalProjectAPI.IServices;
using FinalProjectAPI.Services;

var builder = WebApplication.CreateBuilder(args);
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmployeeDbContext>(options =>
           options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=.NetCoreTraining;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEmployeeService, EmployeeServices>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISoftLockService,SoftLockService >();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(MyAllowSpecificOrigins);
app.UseMiddleware<JwtMiddleware>();
app.MapControllers();

app.Run();
