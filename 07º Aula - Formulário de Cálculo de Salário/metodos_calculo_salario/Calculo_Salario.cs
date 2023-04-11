using Formulário_de_Cálculo_de_Salário.metodos_calculo_salario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário_de_Cálculo_de_Salário
{
    class Calculo_Salario
    {
        public string calc_salario(string nome_funcionario, string cargo,
            double sal_bruto, double desconto, int desc_irrf)
        {
            Calculo_IRRF irrf = new Calculo_IRRF();            
            double retorno_irrf = irrf.calc_irrf(sal_bruto, desc_irrf);

            //bonus
            Bonus_Cargo bc = new Bonus_Cargo();
            double bonus = bc.calculo_bonus(cargo);

            // Calculando salário liquido
            double salario_liquido = 
                ((sal_bruto - desconto) - retorno_irrf) + bonus;
            
            // Texto da caixa salário líquido
            string texto_salario_calculado  = 
                "Nome do funcionário: " + nome_funcionario + Environment.NewLine +
                "Cargo: " + cargo + Environment.NewLine +
                "Salário líquido: " + salario_liquido.ToString("C");

            return texto_salario_calculado;
        }
    }
}
