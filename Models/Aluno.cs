using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCADS2023.Models
{
    enum Periodo { Diurno, Vespertino, Noturno}
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        [Display(Name ="Id")]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório")]
        [StringLength(35)]
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo aniversário é obrigatório")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Anirvesário")]
        public DateTime aniversario { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatório")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Email invalido")]
        [Display(Name = "Email")]
        public string email { get; set; }

        public int cursoID { get; set; }
        [ForeignKey("cursoID")]
        [Display(Name = "Curso")]
        public Curso curso { get; set; }

        [Required(ErrorMessage = "Campo periodo é obrigatório")]
        [Display(Name = "Periodo")]
        public string periodo { get; set; }
    }
}
