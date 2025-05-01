namespace CourseManagementSystem.Models;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    
    public List<Enrollment> Enrollments { get; set; }
}