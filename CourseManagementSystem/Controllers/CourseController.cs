using CourseManagementSystem.DTOs.CourseDTOs;
using CourseManagementSystem.Models;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementSystem.Controllers;

[ApiController]
[Route("courses")]
public class CourseController : ControllerBase
{
    private readonly ICourseRepo _repo;

    public CourseController(ICourseRepo repo) => _repo = repo;

    /// <summary>
    /// Get a paginated list of courses.
    /// </summary>
    /// <param name="pageNumber">Page number (starts at 1)</param>
    /// <param name="pageSize">Number of courses per page</param>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CourseGetDTO>), 200)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> GetAll([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        if (pageNumber <= 0 || pageSize <= 0)
            return BadRequest(new { error = "Page number and page size must be greater than zero." });

        var courses = await _repo.GetPagedAsync(pageNumber, pageSize);

        var result = courses.Select(c => new CourseGetDTO
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description,
            Instructor = c.Instructor
        });

        return Ok(result);
    }

    /// <summary>
    /// Get a course by ID.
    /// </summary>
    /// <param name="id">Course ID</param>
    /// <returns>200 OK or 404 Not Found</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(CourseGetDTO), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var course = await _repo.GetByIdAsync(id);
        if (course == null) return NotFound(new { error = "Course not found." });

        var result = new CourseGetDTO
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            Instructor = course.Instructor
        };

        return Ok(result);
    }

    /// <summary>
    /// Create a new course.
    /// </summary>
    /// <param name="dto">Course data</param>
    /// <returns>201 Created or 400 Bad Request</returns>
    [HttpPost]
    [ProducesResponseType(typeof(Course), 201)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Create([FromBody] CourseCreateDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var course = new Course
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Description = dto.Description,
            Instructor = dto.Instructor
        };

        var result = await _repo.CreateAsync(course);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }

    /// <summary>
    /// Update an existing course.
    /// </summary>
    /// <param name="id">Course ID</param>
    /// <param name="dto">Updated course data</param>
    /// <returns>204 No Content or 404 Not Found</returns>
    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Update(Guid id, [FromBody] CourseUpdateDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var course = await _repo.GetByIdAsync(id);
        if (course == null)
            return NotFound(new { error = "Course not found." });

        course.Title = dto.Title;
        course.Description = dto.Description;
        course.Instructor = dto.Instructor;

        await _repo.UpdateAsync(course);
        return NoContent();
    }

    /// <summary>
    /// Delete a course by ID.
    /// </summary>
    /// <param name="id">Course ID</param>
    /// <returns>204 No Content</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _repo.DeleteAsync(id);
        return NoContent();
    }
}
