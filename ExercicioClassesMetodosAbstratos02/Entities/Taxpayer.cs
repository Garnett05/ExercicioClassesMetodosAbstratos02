using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesMetodosAbstratos02.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Taxpayer()
        {
        }
        public Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double TaxesValue();
    }
}
