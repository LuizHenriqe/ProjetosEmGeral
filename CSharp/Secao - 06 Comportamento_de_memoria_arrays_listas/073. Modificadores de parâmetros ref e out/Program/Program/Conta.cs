using System;
using System.Collections.Generic;
using System.Text;

namespace Program {
    class Conta {
        // Utilizando REF
        public static void Triple(ref int a) {
            a = a * 3;
        }

        // Utilizando out
        public static void Triple2(int b, out int result) {
            result = b * 3;
        }
    }
}
