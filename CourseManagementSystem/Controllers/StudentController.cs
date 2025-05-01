using CourseManagementSystem.DTOs.StudentDTOs;
using CourseManagementSystem.Models;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementSystem.Controllers;

[ApiController]
[Route("students")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepo _repo;

    public StudentController(IStudentRepo repo) => _repo = repo;

    /// <summary>
    /// Get a paginated list of students.
    /// </summary>
    /// <param name="pageNumber">Page number (starts at 1)</param>
    /// <param name="pageSize">Number of students per page</param>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<StudentGetDTO>), 200)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        if (pageNumber <= 0 || pageSize <= 0)
            return BadRequest(new { error = "Page number and page size must be greater than zero." });

        var students = await _repo.GetPagedAsync(pageNumber, pageSize);

        var result = students.Select(s => new StudentGetDTO
        {
            Id = s.Id,
            Name = s.Name,
            Email = s.Email
        });

        return Ok(result);
    }

    /// <summary>
    /// Get a student by ID.
    /// </summary>
    /// <param name="id">Student ID</param>
    /// <returns>Student details</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(StudentGetDTO), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var student = await _repo.GetByIdAsync(id);
        if (student == null)
            return NotFound(new { error = "Student not found." });

        var result = new StudentGetDTO
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email
        };

        return Ok(result);
    }

    /// <summary>
    /// Create a new student.
    /// </summary>
    /// <param name="dto">Student data</param>
    /// <returns>Created student</returns>
    [HttpPost]
    [ProducesResponseType(typeof(Student), 201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] StudentCreateDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var student = new Student
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            Email = dto.Email
        };

        var result = await _repo.CreateAsync(student);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    /// <summary>
    /// Update an existing student.
    /// </summary>
    /// <param name="id">Student ID</param>
    /// <param name="dto">Updated student data</param>
    /// <returns>No content</returns>
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> Update(Guid id, [FromBody] StudentUpdateDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var student = await _repo.GetByIdAsync(id);
        if (student == null)
            return NotFound(new { error = "Student not found." });

        student.Name = dto.Name;
        student.Email = dto.Email;

        await _repo.UpdateAsync(student);
        return NoContent();
    }

    /// <summary>
    /// Delete a student by ID.
    /// </summary>
    /// <param name="id">Student ID</param>
    /// <returns>No content</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _repo.DeleteAsync(id);
        return NoContent();
    }
}
