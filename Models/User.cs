using System.ComponentModel.DataAnnotations;

namespace taskflow.Models
{
    public enum Role
    {
        Admin,
        User
    }

    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "L'email est obligatoire.")]
        [EmailAddress(ErrorMessage = "Format d'email invalide.")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        public string PasswordHash { get; set; }

        [Required]
        public Role Role { get; set; }

        public ICollection<Project>? Projects { get; set; }

        // DTOs internes
        public class RegisterModel
        {
            [Required(ErrorMessage = "Le nom est obligatoire.")]
            [StringLength(50)]
            public string Name { get; set; }

            [Required(ErrorMessage = "L'email est obligatoire.")]
            [EmailAddress(ErrorMessage = "Format d'email invalide.")]
            [StringLength(100)]
            public string Email { get; set; }

            [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
            [MinLength(6, ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères.")]
            public string Password { get; set; }

            public Role? Role { get; set; }
        }

        public class LoginModel
        {
            [Required(ErrorMessage = "L'email est obligatoire.")]
            [EmailAddress(ErrorMessage = "Format d'email invalide.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
            public string Password { get; set; }
        }
    }
}
