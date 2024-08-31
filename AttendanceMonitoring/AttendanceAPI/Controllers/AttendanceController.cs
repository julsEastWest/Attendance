using AttendanceMonitoring.AttendanceAPI.Data;
using AttendanceMonitoring.AttendanceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMonitoring.AttendanceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // have replace the [contoller] with the name of controller actual name.
    public class AttendanceController : ControllerBase 
    {
        private readonly AttendanceContext _context;
        public AttendanceController(AttendanceContext context)
        {
            _context = context;
        }
        [HttpGet] // get all student objects
        public IEnumerable<StudentModels> GetStudents()
        {
            var students = _context.Students.ToList();
             //return _context.Students.ToList();
            return students;
        }

        [HttpGet("{Student_Id}")] // get student object by Id
        public ActionResult<StudentModels> GetStudents(long Student_Id)
        {
        var student = _context.Students.Find(Student_Id);
        if (student == null)
        {
            return NotFound();
        }

        return Ok(student);
    }
        
        
    
        
    }
}
