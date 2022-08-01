using CodeFirstSolo.Context;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstSolo.Extensoes
{
    public static class ServicoExtensoes
    {
        public static void ConfigurarServicos(this IServiceCollection services)
        {
            string connectionString = "Data Source=localhost,1433;User ID=sa;Password=senha@1234;Initial Catalog=BancoAnimais;";

            services.AddDbContext<CadastroDeAnimaisDbContext>(item => item.UseSqlServer(connectionString));

        }
    }
}
