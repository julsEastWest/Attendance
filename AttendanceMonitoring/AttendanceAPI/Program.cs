
using AttendanceMonitoring.AttendanceAPI.Data;
using AttendanceMonitoring.AttendanceAPI.Models;
using AttendanceMonitoring.AttendanceAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddDbContext<AttendanceContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("AttendanceContext"))); // connection string name 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/*using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;       // seed initializer 

    SeedData.Initialize(services);
} */

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
SeedData.Initialize(app.Services);
app.Run();
//






