using System.ComponentModel.DataAnnotations;

namespace taskflow.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom du projet est obligatoire.")]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;

        [Required]
        public int UserId { get; set; }

        public User? User { get; set; }

        public ICollection<TaskItem>? Tasks { get; set; }
    }
}
