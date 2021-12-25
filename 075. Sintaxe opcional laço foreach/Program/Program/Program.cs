using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            //foreach

             string[] nomes = new string[] { "Luiz", "Gaby", "Natalia" };

            // temos dois jeitos de fazer a impressao na tela.

            // Utilizando o FOR
            for (int i = 0; i < nomes.Length; i++) {
                Console.WriteLine(nomes[i]);
            }

            // Podemos utiliza o FOREACH
            foreach (string apelido in nomes) {
                Console.WriteLine(apelido);
            }
        }
    }
}
