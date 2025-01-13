using Microsoft.AspNetCore.Mvc;
using WebApplication6.Dto;
using WebApplication6.Factories;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{

    [Route("v1/")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        #region Ctor & Properties

        private readonly IStudentService _studentService;
        private readonly IStudentFactory _studentFactory;
        public StudentController(IStudentService studentService, IStudentFactory studentFactory)
        {
            _studentService = studentService;
            _studentFactory = studentFactory;
        }

        #endregion


        #region

        [Route("student/{id}")]
        [HttpGet]
        public async Task<ActionResult<StudentDto>> GetStudentById(int id)
        {
            var response = await _studentService.GetStudentByIdAsync(id).ConfigureAwait(false);
            if (response == null)
                return NotFound();
            var mappedData = _studentFactory.MapStudentEntityToDto(response);
            return Ok(mappedData);
        }

        #endregion
    }
}
