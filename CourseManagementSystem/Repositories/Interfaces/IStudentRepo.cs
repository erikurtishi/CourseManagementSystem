using CourseManagementSystem.Models;

namespace CourseManagementSystem.Repositories.Interfaces;

public interface IStudentRepo
{
    Task<IEnumerable<Student>> GetAllAsync();
    Task<Student?> GetByIdAsync(Guid id);
    Task<Student> CreateAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(Guid id);
    Task<IEnumerable<Student>> GetPagedAsync(int pageNumber, int pageSize);
}