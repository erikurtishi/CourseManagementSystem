using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.DTOs.CourseDTOs;

public class CourseCreateDTO
{
    [Required]
    [StringLength(100)]
    public string Title { get; set; } 
    
    [Required]
    [StringLength(300)]
    public string Description { get; set; } 
    
    [Required]
    [StringLength(100)]
    public string Instructor { get; set; }
}