using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesMetodosAbstratos02.Entities
{
    class Individual : Taxpayer
    {
        public double HealthSpending { get; set; }

        public Individual()
        {
        }
        public Individual(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxesValue()
        {
            double txs = 0.0;
            if (AnualIncome <= 20000.00) {
                txs = (AnualIncome * 0.15) - (HealthSpending * 0.5);
            }
            else
            {
                txs = (AnualIncome * 0.25) - (HealthSpending * 0.5);
            }
            return txs;
        }
    }
}
