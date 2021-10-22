using System;
using System.Linq;

namespace ConsoleApp00_PowerUp_04_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Net University | ASP.Net Core 5 | C# Power Up!";
            Console.WriteLine("Loading... Please Wait... Loaded!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aprendiendo Linq");
            Console.WriteLine(Environment.NewLine);

            // Select
            Console.WriteLine("Select");
            int[] numerosSelect = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numerosMultiplicados = from n in numerosSelect
                                       select n * 2;

            foreach (var numero in numerosMultiplicados)
            {
                Console.Write(numero + ", ");
            }
            Console.WriteLine(Environment.NewLine);

            var numerosMultiplicadosEnLambda = numerosSelect.Select(x => x * 2);
            foreach (var numeroB in numerosMultiplicadosEnLambda)
            {
                Console.Write(numeroB + ", ");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Select Many");

            // Select Many
            int[] numerosSelectManyA = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numerosSelectManyB = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var numerosMultiplicadosSelectMany = from x in numerosSelectManyA
                                                 from y in numerosSelectManyB
                                                 select x * y;
            Console.WriteLine(String.Join(',', numerosMultiplicadosSelectMany));

            Console.WriteLine(Environment.NewLine);

            var numerosMultiplicadosSelectManyLambda = numerosSelectManyA.SelectMany(x =>
            numerosSelectManyB.Select(y => x * y));
            Console.WriteLine(String.Join(',', numerosMultiplicadosSelectManyLambda));


            var arregloInception = new[]
            {
                new[] { 1, 2, 3 },
                new[] { 4, 5 },
                new[] { 6 }
            };

            var secuenciaPlana = arregloInception.SelectMany(x => x);
            Console.WriteLine(String.Join(',', secuenciaPlana));

            var armas = new[] { "arco, flecha, espada", "cadena, catana", "staff" };
            var separarPorPalabrasYRetornarUnaLista = armas.SelectMany(x => x.Split(',').Select(y => y.Trim()));
            foreach (var item in separarPorPalabrasYRetornarUnaLista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);
            Console.ReadLine();

            // Where

            // First

            // FirstOrDefault

            // Last

            // LastOrDefault

            // Single

            // SingleOrDefault

            // Except

            // Any

            // Skip & Take

            // Mini buscador: Programando con lo básico de Linq y programado de mejor manera con Linq



        }
    }
}
