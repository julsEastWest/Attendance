
using AttendanceMonitoring.AttendanceAPI.Data;
using AttendanceMonitoring.AttendanceAPI.Models;
using AttendanceMonitoring.AttendanceAPI.Controllers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddDbContext<AttendanceContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("AttendanceContext")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AttendanceContext>();
    dbContext.Database.EnsureCreated();

    dbContext.Students.Add(new StudentModels
    {
        Student_Id = 1,
        Student_yrlvl = 1,
        Student_FName = "Julianna",
        Student_LName = "Juls",
        Student_Email = "julianna@gmail.com"
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
//






