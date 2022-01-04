using System;

namespace Program {
    class Program {
        static void Main(string[] args) {
            //------> struct <------
            Point p; //tipo valor.

            p.X = 100;
            p.Y = 500;
            Console.WriteLine(p);
            // nao precisa instancias, porem o valor nao pode ser nulo.
            p = new Point(); 
            Console.WriteLine(p);

            //C------> class <------
            PointClasse pC = new PointClasse();

            pC.X = 100;


            Console.WriteLine(pC.X);
        }
    }
}
