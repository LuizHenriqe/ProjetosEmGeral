using System;
using System.Collections.Generic;

namespace Program {
    class Program {
        static void Main(string[] args) {

            // Criando lista, "Essa lista é diferente do vetor, que por sua vez pode ser criada vazia"

            List<string> minhaLista = new List<string>();

            // Podemos tambem instanciar a lista diretamente

            List<string> minhaLista2 = new List<string> {"Luiz", "Gaby" };

            // Desvantegem
            // A list nao pode acessar os objetos de forma aleatoria, ela acessa sequencialmente

            // Vantagem 
            // pode ser inicializada vazia
        }
    }
}
