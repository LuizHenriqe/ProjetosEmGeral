using System;
using System.Globalization;

namespace program {
    class ConversorDeMoedas {
        public static double Dolar, CompraDolar, Real;

        public static double ConverteDolarEmReal() {
            Real = Dolar * CompraDolar;
            Real = Real + (Real * 6.00 /100);
            return Real;
        }

        public override string ToString() {
            return "Valor a ser pago em reais: " + Real.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
