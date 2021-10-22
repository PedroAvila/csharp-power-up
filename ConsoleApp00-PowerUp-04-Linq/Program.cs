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

            // Where

            int[] numerosListaParaElWhere = { 1, 4, 7, 8, 5, 2, 3, 6, 9 };
            var numerosParesStatement = from x in numerosListaParaElWhere
                                        where x % 2 == 0
                                        select x;

            Console.WriteLine(String.Join(',', numerosParesStatement));

            var numerosParesLambda = numerosListaParaElWhere.Where(x => x % 2 == 0);
            Console.WriteLine(String.Join(',', numerosParesLambda));

            // First

            var firstA = new[] { "a" }.First();
            var firstB = new[] { "a", "b" }.First();
            var firstC = new[] { "a", "b" }.First(x => x.Equals("a"));
            var firstD = new[] { "aa", "bb", "ab" }.First(x => x.Contains("b"));

            Console.WriteLine(firstA);
            Console.WriteLine(firstB);
            Console.WriteLine(firstC); 
            Console.WriteLine(firstD);

            // Esto genera error
            //var firstE = new[] { "aa", "bb", "cc", "dd" }.First(x => x.Equals("e"));
            //Console.WriteLine(firstE);
            //var firstF = new[] { "aa", "bb", "cc" }.First(x => x.Contains("d"));
            //Console.WriteLine(firstF);

            // FirstOrDefault
            Console.WriteLine("FirstOrDefault");
            var firstOrDefaultA = new[] { "a", "b", "c" }.FirstOrDefault();
            var firstOrDefaultB = new[] { "aa", "d", "e" }.FirstOrDefault(x => x.Equals("e"));
            var firstOrDefaultC = new[] { "ab", "cd", "ed" }.FirstOrDefault(x => x.Contains("d"));
            var firstOrDefaultD = new[] { "ac", "b", "cc" }.FirstOrDefault(x => x.Contains("e"));

            Console.WriteLine(firstOrDefaultA);
            Console.WriteLine(firstOrDefaultB);
            Console.WriteLine(firstOrDefaultC);
            Console.WriteLine(firstOrDefaultD);
            var firstOrDefaultE = new[] { "a", "a", "a" }.FirstOrDefault(x => x.Equals("b"));
            Console.WriteLine($"firstOrDefaultE {firstOrDefaultE}");
            Console.ReadLine();
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
