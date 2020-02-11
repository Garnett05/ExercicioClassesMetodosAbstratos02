using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesMetodosAbstratos02.Entities
{
    class Company : Taxpayer
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }
        public Company(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxesValue()
        {
             double txs = 0.0;
            if (NumberEmployees <= 10)
            {
                txs = AnualIncome * 0.16;
            }
            else {
                txs = AnualIncome * 0.14;
            }
            return txs;
        }
    }
}
