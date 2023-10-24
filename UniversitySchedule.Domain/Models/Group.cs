using System.ComponentModel.DataAnnotations;

namespace UniversitySchedule.Domain.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required(ErrorMessage = "Group Number is required")]
        [StringLength(8, ErrorMessage = "Group Number cannot be longer than 8 characters")]
        public string Name { get; set; }
    }
}