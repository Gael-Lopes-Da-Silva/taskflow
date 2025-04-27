using System.ComponentModel.DataAnnotations;

namespace taskflow.Models
{
    public enum Status
    {
        [Display(Name = "À faire")]
        Afaire,

        [Display(Name = "En cours")]
        Encours,

        [Display(Name = "Terminé")]
        Termine
    }

    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le titre est obligatoire.")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Project? Project { get; set; }

        public DateTime? DueDate { get; set; }

        public List<string>? Commentaire { get; set; } = new List<string>();
    }
}
