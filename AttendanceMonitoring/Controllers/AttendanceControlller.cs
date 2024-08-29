using AttendanceMonitoring.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceMonitoring.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceControlller(StudentContext context) : ControllerBase // primary constructor
    {

    }
}
