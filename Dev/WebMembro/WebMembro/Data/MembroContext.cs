using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WebMembro.Models;


namespace WebMembro.Data
{
    public class MembroContext: DbContext
    {
        private IConfiguration _config;

        public MembroContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        public DbSet<Membro> Membros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("SqlServer"));
        }

    }
}
