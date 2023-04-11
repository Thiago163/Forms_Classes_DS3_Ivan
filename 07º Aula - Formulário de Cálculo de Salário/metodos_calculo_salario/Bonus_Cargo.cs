using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário_de_Cálculo_de_Salário.metodos_calculo_salario
{
    class Bonus_Cargo
    {
        public double calculo_bonus(string cargo)
        {
            double valor_bonus = 0;

            switch (cargo)
            {
                case "Auxiliar": return valor_bonus = 300;
                case "Técnico": return valor_bonus = 400;
                case "Gerente": return valor_bonus = 300;
                case "Supervisor": return valor_bonus = 200;
                case "Diretor": return valor_bonus = 100;
                default: return valor_bonus = 0;
            }

            return valor_bonus;
        }
    }
}
