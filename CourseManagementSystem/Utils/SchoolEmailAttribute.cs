using System.ComponentModel.DataAnnotations;

namespace CourseManagementSystem.Utils;

public class SchoolEmailAttribute : ValidationAttribute
{
    private readonly string _domain = "school.edu";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is string email && email.Contains("@"))
        {
            var domain = email.Split('@')[1];
            if (domain.Equals(_domain, StringComparison.OrdinalIgnoreCase))
                return ValidationResult.Success;

            return new ValidationResult($"Email must be a school address ending in '@{_domain}'.");
        }

        return new ValidationResult("Invalid email format.");
    }
}