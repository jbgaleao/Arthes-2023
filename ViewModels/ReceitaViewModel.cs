using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Arthes.Enums;

namespace Arthes.ViewModels
{
    [Table("Receitas")]
    public class ReceitaViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [DisplayName("Nome Receita")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [Range(1, 99)]
        [DisplayName("Altura(cm)")]
        public decimal Altura { get; set; }

        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [DisplayName("Nível Dificuldade")]
        public NivelDificuldade Dificuldade { get; set; }

        [ForeignKey("RevistaId")]
        public int RevistaId { get; set; }


    }
}