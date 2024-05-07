using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6Parte2
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2");
        }

        public double SalarioLiquido() 
        { 
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100.0;
        }
    }
}
