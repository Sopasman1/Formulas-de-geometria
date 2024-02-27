using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Formulas_de_geometria
{
    internal class Area
    {
        public  double forlmula() 
        {
            double altura = 23;
            double Base = 12;
            double Entre = 2;
            
            double resul = altura * Base / Entre;
            return resul;
        }

        public double forluma1(double altura,double Base , double Entre)
        {
            double resul = altura *  Base / Entre;
            return resul;
        }

        private void formulas2() 
        {
            double altura = 18;
            double Base = 20;
            double Entre = 2;

            double resul = altura * Base / Entre;
            Console.WriteLine("el resultado es" + resul);
        }

        private double altura;
        private double entre;
        private double bASE;

        public double Altura { get => altura; set => altura = value; }
        public double Entre { get => entre; set => entre = value; }
        public double BASE { get => bASE; set => bASE = value; }

        public void formulas(double altura,double entre,double bASE) 
        { 
            this.altura = altura;
            this.entre = entre;
            this.bASE = bASE;
        }
    }
   
}
