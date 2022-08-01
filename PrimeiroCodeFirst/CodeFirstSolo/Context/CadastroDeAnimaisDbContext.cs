using Microsoft.EntityFrameworkCore;

namespace CodeFirstSolo.Context
{
    public class CadastroDeAnimaisDbContext : DbContext
    {

        public CadastroDeAnimaisDbContext(DbContextOptions<CadastroDeAnimaisDbContext> options ) : base(options)
        {

        }

        public DbSet<Animais> Animal { get; set; }

    }
}
