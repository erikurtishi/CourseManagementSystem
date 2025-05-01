using System.ComponentModel.DataAnnotations;
using CourseManagementSystem.Utils;

namespace CourseManagementSystem.DTOs.StudentDTOs;

public class StudentUpdateDTO
{
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; }
    
    [EmailAddress]
    [SchoolEmail]
    public string Email { get; set; }
}