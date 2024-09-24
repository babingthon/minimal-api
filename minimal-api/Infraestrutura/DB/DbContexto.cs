using System.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using minimal_api.Dominio.Entidades;

namespace minimal_api.Infraestrutura.DB
{
    public class DbContexto : DbContext
    {
        private readonly IConfiguration _configuracaoAppSetting;
        public DbContexto(IConfiguration configuracaoAppSetting)
        {
            _configuracaoAppSetting = configuracaoAppSetting;
        }
        public DbSet<Administrador> Administradores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var stringConexao = _configuracaoAppSetting.GetConnectionString("DefaultConnection")?.ToString();

                if (!string.IsNullOrEmpty(stringConexao))
                {
                    optionsBuilder.UseSqlServer(stringConexao);
                }
            }

        }


    }
}