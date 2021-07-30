using System;
using System.Collections.Generic;

namespace ConsoleApp_MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string ejemplo = "Esta frase tiene cinco palabras.";
            int n = ejemplo.ContarPalabras();
            Console.WriteLine("Hay {0} palabras.", n);

            List<int> lista = new List<int> { 9, 8, 7, 6 };
            Console.WriteLine(lista.Combinar());
            Console.ReadLine();
        }


    }
}
