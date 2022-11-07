using LOGICA.CourseLogic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseLogic _courseLogica;
        public CoursesController(ICourseLogic courseLogic)
        {
            _courseLogica = courseLogic;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> GetAlumnos()
        {
            var respose = _courseLogica.GetCursosListar();
            return Ok(respose);
        }


    }
}
