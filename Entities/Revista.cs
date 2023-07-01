using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Arthes.Entities
{
    [Table("Revistas")]
    public class Revista
    {
        [Key]
        public int RevistaId { get; set; }
        public string Tema { get; set; }
        public int NumEdicao { get; set; }
        public int MesEdicao { get; set; }
        public int AnoEdicao { get; set; }


        public ICollection<Receita> ListaReceitas { get; set; }
    }
}