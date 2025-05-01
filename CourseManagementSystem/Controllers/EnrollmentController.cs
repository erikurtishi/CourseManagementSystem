using CourseManagementSystem.DTOs.CourseDTOs;
using CourseManagementSystem.DTOs.StudentDTOs;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementSystem.Controllers;

[ApiController]
[Route("enrollments")]
public class EnrollmentController : ControllerBase
{
    private readonly IEnrollmentRepo _repo;
    private readonly IStudentRepo _students;
    private readonly ICourseRepo _courses;

    public EnrollmentController(IEnrollmentRepo repo, IStudentRepo students, ICourseRepo courses)
    {
        _repo = repo;
        _students = students;
        _courses = courses;
    }

    /// <summary>
    /// Enroll a student into a course.
    /// </summary>
    [HttpPost("students/{id}/courses/{cid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Enroll(Guid id, Guid cid)
    {
        var student = await _students.GetByIdAsync(id);
        if (student == null)
            return NotFound(new { error = "Student not found." });

        var course = await _courses.GetByIdAsync(cid);
        if (course == null)
            return NotFound(new { error = "Course not found." });

        var enrolledCourses = await _repo.GetCoursesByStudentIdAsync(id);
        if (enrolledCourses.Any(c => c.Id == cid))
            return BadRequest(new { error = "Student is already enrolled in this course." });

        await _repo.EnrollStudentAsync(id, cid);
        return Ok(new { message = "Student enrolled successfully." });
    }

    /// <summary>
    /// Unenroll a student from a course.
    /// </summary>
    [HttpDelete("students/{id}/courses/{cid}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(400)]
    public async Task<IActionResult> Unenroll(Guid id, Guid cid)
    {
        var student = await _students.GetByIdAsync(id);
        if (student == null)
            return NotFound(new { error = "Student not found." });

        var course = await _courses.GetByIdAsync(cid);
        if (course == null)
            return NotFound(new { error = "Course not found." });

        var enrolledCourses = await _repo.GetCoursesByStudentIdAsync(id);
        if (!enrolledCourses.Any(c => c.Id == cid))
            return BadRequest(new { error = "Student is not enrolled in this course." });

        await _repo.UnenrollStudentAsync(id, cid);
        return Ok(new { message = "Student unenrolled successfully." });
    }

    /// <summary>
    /// Get all courses that a student is enrolled in.
    /// </summary>
    [HttpGet("students/{id}/courses")]
    [ProducesResponseType(typeof(IEnumerable<CourseGetDTO>), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetCoursesForStudent(Guid id)
    {
        var student = await _students.GetByIdAsync(id);
        if (student == null)
            return NotFound(new { error = "Student not found." });

        var courses = await _repo.GetCoursesByStudentIdAsync(id);
        var result = courses.Select(course => new CourseGetDTO
        {
            Id = course.Id,
            Title = course.Title,
            Description = course.Description,
            Instructor = course.Instructor
        });

        return Ok(result);
    }

    /// <summary>
    /// Get all students enrolled in a course.
    /// </summary>
    [HttpGet("courses/{id}/students")]
    [ProducesResponseType(typeof(IEnumerable<StudentGetDTO>), 200)]
    [ProducesResponseType(404)]
    public async Task<IActionResult> GetStudentsForCourse(Guid id)
    {
        var course = await _courses.GetByIdAsync(id);
        if (course == null)
            return NotFound(new { error = "Course not found." });

        var students = await _repo.GetStudentsByCourseIdAsync(id);
        var result = students.Select(student => new StudentGetDTO
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email
        });

        return Ok(result);
    }
}
