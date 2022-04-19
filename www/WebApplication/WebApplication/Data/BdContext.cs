using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication.Models;


namespace WebApplication.Data {
    public class BdContext: DbContext {
        private IConfiguration _configuration;

        public BdContext(IConfiguration configuration) {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
          optionsBuilder.UseMySQL(_configuration.GetConnectionString("MySql"));
        }

        public DbSet<WebApplication.Models.Membro> Membro { get; set; }
    }
}
