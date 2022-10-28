using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class PJ : Pessoa
    {
        public int NumberOfEmployees { get; set; }


        public PJ(string name,double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculaRenda()
        {
            double valor;

            if(NumberOfEmployees >= 10)
            {
                valor = AnualIncome * 0.14;
            }
            else
            {
                valor = AnualIncome * 0.16;
            }

            return valor;
        }

        public override string CalcImpostoRet()
        {
            double valor = CalculaRenda();
            return $"{Name}: $ {valor.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
