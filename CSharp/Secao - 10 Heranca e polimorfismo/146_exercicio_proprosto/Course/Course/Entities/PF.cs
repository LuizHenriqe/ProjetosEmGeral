using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class PF : Pessoa
    {
        public double HealthExpenditures { get; set; }

        public PF(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculaRenda()
        {
            double renda = 0;

            if(AnualIncome >= 20000.00)
            {
                renda = AnualIncome * 0.25;
            }
            else
            {
                renda = AnualIncome * 0.15;
            }

            if(HealthExpenditures != 0)
            {
                renda = renda - (HealthExpenditures * 0.50);
            }

            return renda;
        }
        public override string CalcImpostoRet()
        {
            double valor = CalculaRenda();
            return  $"{Name}: $ {valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
