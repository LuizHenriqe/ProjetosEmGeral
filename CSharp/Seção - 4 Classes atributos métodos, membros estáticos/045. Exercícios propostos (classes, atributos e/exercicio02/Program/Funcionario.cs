using System;
using System.Globalization;

namespace Program {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);
            
        }

        public override string ToString() {
            return "Funcionario: "
            + Nome.ToUpper()
            + ", " + "$ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}

