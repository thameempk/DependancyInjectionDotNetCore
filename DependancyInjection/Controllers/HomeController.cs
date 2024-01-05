using DependancyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependancyInjection.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    
    public class HomeController : Controller
    {
        private readonly IStudentRepository? _repository = null;
        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult AllStudents()
        {
            List<Students>? allStudentDetails = _repository?.GetAllStudent();
            return Ok(allStudentDetails);
        }
        [HttpGet("{id}")]
        public ActionResult GetStudentDetails(int id)
        {
            Students? studentDetails = _repository?.GetStudentById(id);
            return Ok(studentDetails);
        }
    }
}
