﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impostos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberofEmployees { get; set; }
        public Company() { }
        public Company(int numberofEmployees, string name, double anualIncome)
        : base(name, anualIncome)
        {
            NumberofEmployees = numberofEmployees;
        }

        public override double Tax()
        {
            if (NumberofEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
