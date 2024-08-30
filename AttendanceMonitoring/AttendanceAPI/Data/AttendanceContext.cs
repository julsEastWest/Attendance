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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 
        //seed data
        modelBuilder.Entity<StudentModels>().HasData(
            new StudentModels
            {
                Student_Id = 1,
                Student_yrlvl = 1,
                Student_FName = "John",
                Student_LName = "Doe",
                Student_Email = "johndoe@gmail.com"
            
            }
        );
    }
}