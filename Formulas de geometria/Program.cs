namespace Formulas_de_geometria
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Area area = new Area();

            double resultado1 = area.forlmula();
            Console.WriteLine("Resultado de la fórmula sin parámetros: " + resultado1);

            double resultado2 = area.forluma1(23, 12, 2);
            Console.WriteLine("Resultado de la fórmula con parámetros: " + resultado2);

            area.formulas(18, 24, 2);
            Console.WriteLine("resultado sin lectura" + area.Altura * area.BASE / area.Entre);
         

        }
    }
}
