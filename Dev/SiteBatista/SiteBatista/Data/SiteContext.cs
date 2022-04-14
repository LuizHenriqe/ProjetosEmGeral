using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SiteBatista.Models;

namespace SiteBatista.Data {
    public class SiteContext : DbContext{
        private IConfiguration _configuration;

        public SiteContext(IConfiguration configuration) {
            _configuration = configuration;
        }
        public DbSet<Membro> Membros { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("MySQL"));
        }
    }
}
