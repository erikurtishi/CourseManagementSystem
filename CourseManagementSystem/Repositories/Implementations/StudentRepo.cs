using CourseManagementSystem.Data;
using CourseManagementSystem.Models;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Repositories.Implementations;

public class StudentRepo : IStudentRepo
{
    private readonly AppDbContext _context;
    public StudentRepo(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Student>> GetAllAsync() => await _context.Students.ToListAsync();

    public async Task<Student?> GetByIdAsync(Guid id) => await _context.Students.FindAsync(id);

    public async Task<Student> CreateAsync(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
        return student;
    }

    public async Task UpdateAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var student = await GetByIdAsync(id);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
    
    public async Task<IEnumerable<Student>> GetPagedAsync(int pageNumber, int pageSize)
    {
        return await _context.Students
            .Include(s => s.Enrollments).ThenInclude(e => e.Course)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}