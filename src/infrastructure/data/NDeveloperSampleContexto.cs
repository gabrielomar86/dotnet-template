using GuayaswestSample.core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace GuayaswestSample.infrastructure.data
{
    public class GuayaswestSampleContexto : DbContext
    {
        private IDbContextTransaction contextoTransaction;

        public GuayaswestSampleContexto(DbContextOptions<GuayaswestSampleContexto> options) : base(options) { }

        public DbSet<GuayaswestSampleEntity> GuayaswestSampleEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CargarDatosIniciales(modelBuilder);
        }

        public virtual void IniciarTransaccion()
        {
            contextoTransaction = Database.BeginTransaction();
        }

        public virtual void ConfirmarTransaccion()
        {
            try
            {
                SaveChanges();
                contextoTransaction.Commit();
            }
            finally
            {
                contextoTransaction.Dispose();
            }
        }

        public virtual void RevertirTransaccion()
        {
            if (contextoTransaction != null)
            {
                contextoTransaction.Rollback();
                contextoTransaction.Dispose();
            }
        }

        private static void CargarDatosIniciales(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GuayaswestSampleSemilla());
        }
    }
}