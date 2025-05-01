namespace CourseManagementSystem.DTOs.CourseDTOs;

public class CourseGetDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Instructor { get; set; }
}