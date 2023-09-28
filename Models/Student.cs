using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BaltaTeste.Models
{
    public class Student
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O nome deve ter entre {1} e {0} caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o e-mail")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;

        public List<Premium> Premiums { get; set; } = new();
    }
}
