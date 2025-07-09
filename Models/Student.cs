using System.ComponentModel.DataAnnotations;

namespace CRUDapp.Models
{
    public class Student
    {
        [Key]
        [Display (Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enrollmen tDate")]
        public DateTime EnrollmentDate { get; set; }
    }
}
