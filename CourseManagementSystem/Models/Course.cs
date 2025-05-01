namespace CourseManagementSystem.Models;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Instructor { get; set; }
    
    public List<Enrollment> Enrollments { get; set; }
}