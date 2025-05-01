using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.DTOs.CourseDTOs;

public class CourseUpdateDTO
{
    [StringLength(100)]
    public string Title { get; set; } 
    
    [StringLength(300)]
    public string Description { get; set; } 
    
    [StringLength(100)]
    public string Instructor { get; set; }
}