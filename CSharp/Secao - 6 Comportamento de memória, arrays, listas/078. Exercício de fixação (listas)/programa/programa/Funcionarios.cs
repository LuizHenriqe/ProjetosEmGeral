using System;
using System.Globalization;
using System.Collections.Generic;

namespace programa {
    class Funcionarios {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id,string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double EfetuaPorcentagem(double porcentagem) {
            return Salario += Salario * porcentagem / 100;
        }

        public override string ToString() {
            return Id + ", "+ Nome+ ", "+ Salario ;
        }
    }
}
