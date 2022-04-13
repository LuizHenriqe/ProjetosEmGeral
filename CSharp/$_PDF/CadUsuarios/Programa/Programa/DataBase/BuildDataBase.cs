using Microsoft.EntityFrameworkCore;
using Programa.Models;

namespace Programa.DataBase {
    class BuildDataBase : DbContext {
        public BuildDataBase() : base() //  -> Cria construtor do banco de dados...
        {
            Database.EnsureCreated();   //  -> Cria o banco de dados automaticamente...
        }

        //  -> Cria instancia do tipo Usuarios.cs -> Use o DbSet<"Usuario.cs(EXEMPLO)">...
        public DbSet<Usuario> SetUsuarios { get; set;}

        //  -> Cria caminho para salvar o banco.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlite(@"Data Source =C:\Users\Luiz Henrique\Desktop\CadUsuarios\Programa\Programa\DataBaseUsua.db");
        }

        // 1. abra o "Console do Gerenciador de Pacotes".
        // 2. crie a migration com o comando: add-migration NOME_DA_MIGRACAO.
        // 3. digite o comando: Update-Database.
    }
}
