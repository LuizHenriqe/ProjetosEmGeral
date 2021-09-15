using System;
using System.Globalization;

namespace exercicio03 {
    class Aluno {
        public double Media, ValorAprovado = 6.00, FaltouTantosPontos;
        public string Nome;
       

        public void MediaNotas(double a, double b, double c) {
            double soma = a + b + c;
            Media = soma / 3;
            FaltouTantosPontos = ValorAprovado - Media;
        }


        public override string ToString() {
            string texto;

            if (Media >= ValorAprovado) {
            texto = "APROVADO!";
            }
            else {
            texto = "REPROVADO! FALTARAM " + FaltouTantosPontos+ " PONTOS.";
                
            }

            return "NOTA FINAL DO ALUNO "
            + Nome + " é = " + Media.ToString("F2", CultureInfo.InvariantCulture) +"\n" + texto;
        }
    }
}
