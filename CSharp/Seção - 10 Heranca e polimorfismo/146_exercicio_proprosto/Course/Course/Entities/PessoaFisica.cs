using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class PessoaFisica: Pessoa
    {
        public double GastoSaude {get; set;}

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude):base(nome,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcImposto()
        {
            double renda=RendaAnual;
            if(renda >= 20000)
            {
                renda = 
            }
          
            return  ;
        }

    }
}
