using CourseManagementSystem.Data;
using CourseManagementSystem.Models;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Repositories.Implementations;

public class EnrollmentRepo : IEnrollmentRepo
{
    private readonly AppDbContext _context;
    public EnrollmentRepo(AppDbContext context) => _context = context;

    public async Task EnrollStudentAsync(Guid studentId, Guid courseId)
    {
        var exists = await _context.Enrollments.FindAsync(studentId, courseId);
        if (exists == null)
        {
            _context.Enrollments.Add(new Enrollment { StudentId = studentId, CourseId = courseId });
            await _context.SaveChangesAsync();
        }
    }

    public async Task UnenrollStudentAsync(Guid studentId, Guid courseId)
    {
        var enrollment = await _context.Enrollments.FindAsync(studentId, courseId);
        if (enrollment != null)
        {
            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Course>> GetCoursesByStudentIdAsync(Guid studentId)
    {
        return await _context.Enrollments
            .Where(e => e.StudentId == studentId)
            .Select(e => e.Course)
            .ToListAsync();
    }

    public async Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(Guid courseId)
    {
        return await _context.Enrollments
            .Where(e => e.CourseId == courseId)
            .Select(e => e.Student)
            .ToListAsync();
    }
}