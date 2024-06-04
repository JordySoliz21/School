using System.ComponentModel.DataAnnotations;

namespace School_API.Dto
{
    public class StudentUpdateDto
    {
        [Required]
        public int StudentId { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        public bool Registered { get; set; }
    }
}
