using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário_de_Cálculo_de_Salário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculo_Salario cs = new Calculo_Salario();

            txt_salario_liquido.Text =
                cs.calc_salario(txt_nome.Text, txt_cargo.Text,
                Double.Parse(txt_salario_bruto.Text),
                Double.Parse(txt_descontos.Text),
                Int32.Parse(txt_irrf.Text));
        }
    }
}
