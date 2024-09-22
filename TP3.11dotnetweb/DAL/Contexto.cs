using Microsoft.EntityFrameworkCore;
using TP3._11dotnetweb.Models;

namespace TP3._11dotnetweb.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Passaporte> Passaportes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Quando usarmos o  FluentAPI colocaremos as referencias aqui de relacionamento
            base.OnModelCreating(modelBuilder);
        }
    }
}
