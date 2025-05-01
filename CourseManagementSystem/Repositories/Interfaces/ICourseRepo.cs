using CourseManagementSystem.Models;

namespace CourseManagementSystem.Repositories.Interfaces;

public interface ICourseRepo
{
    Task<IEnumerable<Course>> GetAllAsync();
    Task<Course?> GetByIdAsync(Guid id);
    Task<Course> CreateAsync(Course course);
    Task UpdateAsync(Course course);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<Course>> GetPagedAsync(int pageNumber, int pageSize);
}