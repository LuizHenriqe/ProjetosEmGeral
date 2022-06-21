using System;
using Programa.DataBase;
using Programa.Models;
using System.Linq;

namespace Programa 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            
            // -> Cria a instancia do BuildDatabase.cs
            var build = new BuildDataBase();

            var usuario = new Usuario {
                ID = 11,
                NAME = "luiz  "
            };  

            // -> SAVE parametro...
            build.SetUsuarios.Add(usuario);
            build.SaveChanges();

            // Select 
            var selecionaUsuario = build.SetUsuarios.Where(x => x.NAME == "teste02").FirstOrDefault();

            Console.WriteLine(selecionaUsuario);

            // Delete
            build.SetUsuarios.Remove(selecionaUsuario);
            build.SaveChanges();

        }
    }
}
