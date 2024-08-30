using System.ComponentModel.DataAnnotations;    
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceMonitoring.AttendanceAPI.Models;

public class CourseModel
{
    // The properties for Course model
    [Key]
    public long Course_Id{ get; set; }
    [Required]
    public required string? Course_Name{ get; set; }
    [Required]
    public required int Date_Enrolled{ get; set; }
}