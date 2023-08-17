using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WMVCADS2023.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nome { get; set; }
        public DateTime aniversario { get; set; }
        [Required]
        public Curso curso { get; set; }
        public string periodo { get; set; }
    }
}
