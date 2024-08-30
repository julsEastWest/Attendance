using System.ComponentModel.DataAnnotations;    
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceMonitoring.AttendanceAPI.Models;
public class StudentModels
{
    // The properties for student model
    [Key]
    public long Student_Id{ get; set; }
    [Required]
    public required int Student_yrlvl{ get; set; }
    [Required]
    public required string? Student_FName{ get; set; }
    [Required]
    public required string? Student_LName{ get; set; }
    [Required]
    public required string? Student_Email { get; set; }
}