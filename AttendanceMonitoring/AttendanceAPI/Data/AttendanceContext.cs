using Microsoft.EntityFrameworkCore;   
using AttendanceMonitoring.AttendanceAPI.Models;

namespace AttendanceMonitoring.AttendanceAPI.Data;

public class AttendanceContext : DbContext
{
    public AttendanceContext(DbContextOptions<AttendanceContext> options) : base(options)
    {

    }
    public DbSet<CourseModel> Courses { get; set; }
    public DbSet<EnrolleeModels> Enrollees { get; set; }
    public DbSet<StudentModels> Students { get; set; }
}