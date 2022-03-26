using Microsoft.EntityFrameworkCore;
using EstacaoRecargaModelo = EstacaoRecarga.Dominio.Entidades.EstacaoRecarga;

namespace EstacaoRecarga.Data.Config
{
    public class EstacaoRecargaDbContext : DbContext
    {
        private readonly string _dbConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=EstacaoRecargaDB;Trusted_Connection=True;MultipleActiveResultSets=True";

        public DbSet<EstacaoRecargaModelo> EstacoesRecargas { get; set; }

        public EstacaoRecargaDbContext()
        {

        }

        public EstacaoRecargaDbContext(DbContextOptions<EstacaoRecargaDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(_dbConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
