using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6Parte3
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double MediaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3; 
        }

        public bool Aprovado() 
        {
            if (MediaFinal() >= 60) {
            return true;
            }

            else { 
            return false;
            }
        }

        public double Restante() 
        {
            if (Aprovado()) 
            {
                return 0.0;
            }
            else
            {
                return 60.0 - MediaFinal();
            }
        }
    }
}
