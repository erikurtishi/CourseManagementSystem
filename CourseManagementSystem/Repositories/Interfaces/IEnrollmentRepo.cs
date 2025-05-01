using CourseManagementSystem.Models;

namespace CourseManagementSystem.Repositories.Interfaces;

public interface IEnrollmentRepo
{
    Task EnrollStudentAsync(Guid studentId, Guid courseId);
    Task UnenrollStudentAsync(Guid studentId, Guid courseId);
    Task<IEnumerable<Course>> GetCoursesByStudentIdAsync(Guid studentId);
    Task<IEnumerable<Student>> GetStudentsByCourseIdAsync(Guid courseId);
}