using Microsoft.EntityFrameworkCore;   

namespace AttendanceMonitoring.Models;

public class StudentContext(DbContextOptions<StudentContext> options) : DbContext(options)
{
    public DbSet<StudentModels> Students { get; set; } = null;
}