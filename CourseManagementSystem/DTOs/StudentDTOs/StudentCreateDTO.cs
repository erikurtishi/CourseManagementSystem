using System.ComponentModel.DataAnnotations;
using CourseManagementSystem.Utils;

namespace CourseManagementSystem.DTOs.StudentDTOs;

public class StudentCreateDTO
{
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; }
    
    [Required]
    [EmailAddress]
    [SchoolEmail]
    public string Email { get; set; }
}