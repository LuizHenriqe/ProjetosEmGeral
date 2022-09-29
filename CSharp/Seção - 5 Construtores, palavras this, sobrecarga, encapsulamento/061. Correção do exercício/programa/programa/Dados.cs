using System;
using System.Threading;

namespace programa {
    class Dados {

        private string _nomeConta;
        private double _depositoInicial; // opcional 
        private int _numeroConta;

        public Dados(int numeroConta, string nome) {
            _numeroConta = numeroConta;
            _nomeConta = nome;
        }

        public double AdicionaDeposito(double valor) {
            return _depositoInicial += valor;
        }
        public double SaqueConta(double valor) {
            return _depositoInicial -= valor + 5;
        }
        public void Carregar() {
            Console.WriteLine("Carregando!!");
            for (int i = 0; i < 3; i++) {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }

        public override string ToString() {
            return "Conta: " + _numeroConta
            + ", Titular: " + _nomeConta
            + ", Saldo: $" + _depositoInicial;
        }
    }
}
