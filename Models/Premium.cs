using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BaltaTeste.Models
{
    public class Premium
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do Premium")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "O título deve ter entre {1} e {0} caracteres")]
        [DisplayName("Título")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        [DisplayName("Inicio")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Termino")]
        public DateTime EndDate { get; set; }


        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]
        public int StudentId { get; set; }

        public Student? Student { get; set; }
    }
}
