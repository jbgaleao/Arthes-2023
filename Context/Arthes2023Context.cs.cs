using System.Data.Entity;

using Arthes.Entities;

namespace Arthes.Context
{
    public class Arthes2023Context : DbContext
    {
        public Arthes2023Context() : base("ArthesConn") { }

        //  ENTIDADES
        public DbSet<Revista> Revistas { get; set; }
        public DbSet<Receita> Receitas { get; set; }

        //  TABELAS MAPEADAS
        //public DbSet<RevistaViewModel> RevistasViewModel { get; set; }
        //public DbSet<ReceitaViewModel> ReceitasViewModel { get; set; }

    }
}