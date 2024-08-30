using System.ComponentModel.DataAnnotations;    
using System.ComponentModel.DataAnnotations.Schema;


namespace AttendanceMonitoring.AttendanceAPI.Models;
public class EnrolleeModels
{
    // The properties for Enrollee model
    [Key]
    public long Enrollee_Id{ get; set; }

    [ForeignKey("Student_Id")]
    public StudentModels? Student{ get; set; }
    public long Student_Id{ get; set; }

    [ForeignKey("Course_Id")]
    public CourseModel? Course{ get; set; }
    public long Course_Id{ get; set; }
}