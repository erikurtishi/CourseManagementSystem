using CourseManagementSystem.Data;
using CourseManagementSystem.Models;
using CourseManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Repositories.Implementations;

public class CourseRepo : ICourseRepo
{
    private readonly AppDbContext _context;
    public CourseRepo(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Course>> GetAllAsync() => await _context.Courses.ToListAsync();

    public async Task<Course?> GetByIdAsync(Guid id) => await _context.Courses.FindAsync(id);

    public async Task<Course> CreateAsync(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
        return course;
    }

    public async Task UpdateAsync(Course course)
    {
        _context.Courses.Update(course);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var course = await GetByIdAsync(id);
        if (course != null)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }
    }
    
    public async Task<IEnumerable<Course>> GetPagedAsync(int pageNumber, int pageSize)
    {
        return await _context.Courses
            .Include(c => c.Enrollments).ThenInclude(e => e.Student)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}