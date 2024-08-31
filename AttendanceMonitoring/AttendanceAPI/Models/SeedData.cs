using AttendanceMonitoring.AttendanceAPI.Data;
using AttendanceMonitoring.AttendanceAPI.Models;
using AttendanceMonitoring.AttendanceAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace AttendanceMonitoring.AttendanceAPI.Models;
public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<AttendanceContext>();

            if(context.Students.Any())
            {
                return;
            }
                context.Students.AddRange(
                    new StudentModels
                    {
                        Student_yrlvl = 12,
                        Student_FName = "Julia",
                        Student_LName = "Anna",
                        Student_Email = "julia.anna@gmail.com"
                    },
                    new StudentModels
                    {
                        Student_yrlvl = 13,
                        Student_FName = "John",
                        Student_LName = "Doe",
                        Student_Email = "john.doe@gmail.com"
                    },
                    new StudentModels
                    {
                        Student_Id = 3,
                        Student_yrlvl = 14,
                        Student_FName = "Jane Smith",
                        Student_LName = "Jane",
                        Student_Email = "jane.smith@gmail.com",
                    }
                    
                );
                context.SaveChanges();
        }
    }
   
    
}