using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    internal class Employers
    {
        public int ID {  get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set ; }

        public Employers(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario (double porcentagem) 
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return ID + " " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
