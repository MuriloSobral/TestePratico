using Microsoft.EntityFrameworkCore;
using PROJUR.Dominio.Entidade;


namespace PROJUR.Infra.Data
{
    public class  Contexto : DbContext
    {
        public Contexto()
        {
        }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer("Data Source=DESKTOP-S8UJM5S;Initial Catalog=PROJUR;Integrated Security=True");
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
