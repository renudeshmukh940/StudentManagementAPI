using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        // GET: api/students
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentService.GetAllStudentsAsync();

            return Ok(new
            {
                Success = true,
                Message = "Students fetched successfully.",
                Data = students
            });
        }


        // GET: api/students/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);

            if (student == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "Student not found."
                });
            }

            return Ok(new
            {
                Success = true,
                Message = "Student fetched successfully.",
                Data = student
            });
        }


        // POST: api/students
        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Success = false,
                    Message = "Invalid student data.",
                    Errors = ModelState
                });
            }

            var result = await _studentService.AddStudentAsync(student);

            return CreatedAtAction(
                nameof(GetStudentById),
                new { id = result.Id },
                new
                {
                    Success = true,
                    Message = "Student added successfully.",
                    Data = result
                });
        }


        // PUT: api/students/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(
            int id,
            [FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    Success = false,
                    Message = "Invalid student data.",
                    Errors = ModelState
                });
            }


            if (id != student.Id)
            {
                return BadRequest(new
                {
                    Success = false,
                    Message = "Student Id mismatch."
                });
            }


            var result = await _studentService.UpdateStudentAsync(student);


            if (result == null)
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "Student not found."
                });
            }


            return Ok(new
            {
                Success = true,
                Message = "Student updated successfully.",
                Data = result
            });
        }


        // DELETE: api/students/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var result = await _studentService.DeleteStudentAsync(id);


            if (!result)
            {
                return NotFound(new
                {
                    Success = false,
                    Message = "Student not found."
                });
            }


            return Ok(new
            {
                Success = true,
                Message = "Student deleted successfully."
            });
        }
    }
}