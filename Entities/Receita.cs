using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Arthes.Enums;

namespace Arthes.Entities
{
    [Table("Receitas")]
    public class Receita
    {
        [Key]
        public int ReceitaId { get; set; }
        public string Nome { get; set; }
        public int Altura { get; set; }
        public NivelDificuldade Dificuldade { get; set; }


        public int RevistaId { get; set; }
        public Revista Revista { get; set; }
    }
}