using System;

namespace ConosoleTeste {
    class Estudante {
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }

        public Estudante(string nome, string email) {
            NomeEstudante = nome;
            EmailEstudante = email;
        }

        public override string ToString() {
            return NomeEstudante + ", " + EmailEstudante;
        }
    }
}
