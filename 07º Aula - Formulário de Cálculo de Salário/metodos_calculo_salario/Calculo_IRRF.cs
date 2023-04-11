using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário_de_Cálculo_de_Salário
{
    class Calculo_IRRF
    {
        // método com retorno e com parâmetro
        public double calc_irrf(double sal_bruto, int desc_irrf)
        {
            double total_desconto_irrf = (sal_bruto / 100) * desc_irrf;            
            return total_desconto_irrf;
        }

    }
}
