using CourseManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Enrollment>()
    //         .HasKey(e => new { e.StudentId, e.CourseId });
    //
    //     var student1Id = Guid.NewGuid();
    //     var student2Id = Guid.NewGuid();
    //     var course1Id = Guid.NewGuid();
    //     var course2Id = Guid.NewGuid();
    //
    //     modelBuilder.Entity<Student>().HasData(
    //         new Student { Id = student1Id, Name = "Alice Smith", Email = "alice@school.edu" },
    //         new Student { Id = student2Id, Name = "Bob Johnson", Email = "bob@school.edu" }
    //     );
    //
    //     modelBuilder.Entity<Course>().HasData(
    //         new Course { Id = course1Id, Title = "Math 101", Description = "Basic Algebra and Calculus", Instructor = "Prof. Newton" },
    //         new Course { Id = course2Id, Title = "Physics 201", Description = "Mechanics and Thermodynamics", Instructor = "Prof. Einstein" }
    //     );
    //
    //     modelBuilder.Entity<Enrollment>().HasData(
    //         new Enrollment { StudentId = student1Id, CourseId = course1Id },
    //         new Enrollment { StudentId = student2Id, CourseId = course2Id },
    //         new Enrollment { StudentId = student1Id, CourseId = course2Id }
    //     );
    // }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.StudentId, e.CourseId });

        var studentIds = new List<Guid>();
        var courseIds = new List<Guid>();

        for (int i = 1; i <= 15; i++)
        {
            studentIds.Add(Guid.NewGuid());
            courseIds.Add(Guid.NewGuid());
        }

        // Seed Students
        var students = studentIds.Select((id, i) => new Student
        {
            Id = id,
            Name = $"Student {i + 1}",
            Email = $"student{i + 1}@school.edu"
        }).ToArray();

        modelBuilder.Entity<Student>().HasData(students);

        // Seed Courses
        var courses = courseIds.Select((id, i) => new Course
        {
            Id = id,
            Title = $"Course {i + 1}",
            Description = $"Description for Course {i + 1}",
            Instructor = $"Instructor {i + 1}"
        }).ToArray();

        modelBuilder.Entity<Course>().HasData(courses);

        // Seed Enrollments — each student enrolls in 3 courses
        var enrollments = new List<Enrollment>();
        for (int i = 0; i < studentIds.Count; i++)
        {
            var sId = studentIds[i];
            enrollments.Add(new Enrollment { StudentId = sId, CourseId = courseIds[(i + 0) % 15] });
            enrollments.Add(new Enrollment { StudentId = sId, CourseId = courseIds[(i + 1) % 15] });
            enrollments.Add(new Enrollment { StudentId = sId, CourseId = courseIds[(i + 2) % 15] });
        }

        modelBuilder.Entity<Enrollment>().HasData(enrollments);
    }
}