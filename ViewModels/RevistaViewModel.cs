using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arthes.ViewModels
{
    [Table("Revistas")]
    public class RevistaViewModel
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [DisplayName("Tema Revista")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [Range(1, 999)]
        [DisplayName("Número Edição")]
        public int NumEdicao { get; set; }

        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [Range(1, 12)]
        [DisplayName("Mês Edição")]
        public int MesEdicao { get; set; }

        [Required(ErrorMessage = "O '{0}' é um Campo Obrigatório")]
        [Range(2018, 2030, ErrorMessage = "0 '{0}' deve estar entre '{1}' e '{2030}'")]
        [DisplayName("Ano Edição")]
        public int AnoEdicao { get; set; }
    }
}