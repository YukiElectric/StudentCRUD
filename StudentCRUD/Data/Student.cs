using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCRUD.Data
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string StudentName { get; set;}

        [Required]
        [MaxLength(100)]
        public string StudentClass { get; set;}

        [Required]
        [MaxLength(100)]
        public string StudentAcademy { get; set;}

        [Range(0, 4.0)]                   
        public double StudentCPA { get; set;}
    }
}
