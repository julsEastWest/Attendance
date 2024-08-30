using AttendanceMonitoring.AttendanceAPI.Data;
using AttendanceMonitoring.AttendanceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMonitoring.AttendanceAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")] // have replace the [contoller] with the name of controller actual name.
    public class AttendanceController : ControllerBase 
    {
        private readonly AttendanceContext _context;
        public AttendanceController(AttendanceContext context)
        {
            _context = context;
        }
       /* [HttpGet]
        public List<StudentModels> GetStudents()    
        {
           var student = _context.Students.ToList();
           return student;
        } */
    [HttpGet]
    public async Task<ActionResult<StudentModels>> GetStudent(long Student_Id)
    {
        var student = await _context.Students.FindAsync(Student_Id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(student);
         
         
         //return _context.Students.FirstOrDefault(s => s.Student_Id == Student_Id);
    }
        
    }
}
