using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentCRUD.Models;
using StudentCRUD.Repositories.IRepo;

namespace StudentCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository student;

        public StudentController(IStudentRepository studentRepository) {
            student = studentRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllStudents(int page, int limit) {
            try
            {
                return Ok(await student.GetAllStudentAsync(page, limit));

            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var result = await student.GetStudentByIDAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpGet("Search")]
        [Authorize]
        public async Task<IActionResult> GetStudentByCondition(string condition)
        {
            var result = await student.GetAllStudentByCondition(condition);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        [Authorize("admin")]
        public async Task<IActionResult> AddNewStudent(StudentModel model)
        {
            try
            {
                await student.AddStudentAsync(model);
                return Ok();
            }catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Authorize("admin")]
        public async Task<IActionResult> UpdateStudent(int id, StudentModel model)
        {
            if (id != model.StudentId)
            {
                return NotFound();
            }
            await student.UpdateStudentAsync(id, model);
            return Ok();
        }

        [HttpDelete]
        [Authorize("admin")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            await student.DeleteStudentAsync(id);
            return Ok();
        }
    }
}
