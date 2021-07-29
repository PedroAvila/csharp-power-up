using System;
using System.Collections.Generic;

namespace ConsoleApp00_PowerUp_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Net University | ASP.net Core 3 | C# Power Up!";
            Console.WriteLine("Loading... Wait... Loaded!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aprendiendo Action");
            Console.WriteLine(Environment.NewLine);

            Action action = delegate ()
            {
                Console.WriteLine("Ejecutamos un action sin parámetros");
            };
            action();

            Action otraAccion = () =>
             {
                 Console.WriteLine("Ejecutamos otra action sin parámetros");
                 Console.WriteLine("Esto es equivalente al anterior");
             };
            otraAccion();

            Action<string> imprimirCadenaInversa = delegate (string texto)
            {
                char[] caractares = texto.ToCharArray();
                Array.Reverse(caractares);
                Console.WriteLine(new string(caractares));
            };

            imprimirCadenaInversa("Net University Ninja! Aprendiendo con @fredyfx");

            Action<string> mostrarCadenaInversa = (string texto) =>
            {
                char[] caractares = texto.ToCharArray();
                Array.Reverse(caractares);
                Console.WriteLine(new string(caractares));
            };
            mostrarCadenaInversa("Net University Ninja! Aprendiendo con @fredyfx");
            mostrarCadenaInversa("Sin utilizar la palabra delegado");

            Action<string> procesandoCadenaInversaAction = (texto) =>
            {
                char[] caractares = texto.ToCharArray();
                Array.Reverse(caractares);
                Console.WriteLine(new string(caractares));
            };

            procesandoCadenaInversaAction("Vamos instalando nuevo conocimiento :D");

            Action<int> obtenerRaizCuadrada = delegate (int numero)
            {
                Console.WriteLine(Math.Sqrt(numero));
            };

            obtenerRaizCuadrada(144);

            Action<int> obtenerRaizCuadrada2 = num =>
            {
                Console.WriteLine(Math.Sqrt(num));
            };

            Action<int> obtenerRaizCuadrada3 = num => Console.WriteLine(Math.Sqrt(num));

            obtenerRaizCuadrada2(144);
            obtenerRaizCuadrada3(144);

            Action<IEnumerable<double>> generarSumatoria = delegate (IEnumerable<double> listaNumeros)
            {
                double total = 0;
                foreach (double numero in listaNumeros)
                {
                    total = total + numero;
                }
                Console.WriteLine($"La sumatoria es: { total }");
            };

            generarSumatoria(new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 });

            Action<IList<double>> generarPromedio = listaNumeros =>
            {
                double total = 0;
                foreach (double numero in listaNumeros)
                {
                    total = total + numero;
                }
                Console.WriteLine($"El promedio es: { total / listaNumeros.Count }");
            };
            generarPromedio(new double[] { 1, 2, 3, 4, 5, 6, 7 });

            Console.ReadLine();
        }
    }
}
