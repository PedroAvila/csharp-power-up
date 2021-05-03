using System;

namespace ConsoleApp00_PowerUp
{
    // Crear el delegado
    delegate void ProcesandoCadenasDeTexto(string input);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Net University | ASP.net Core 3 | C# Power Up!";
            Console.WriteLine("Loading... Please Wait... Loaded!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aprendiendo Delegates");
            Console.WriteLine(Environment.NewLine);

            var frodo = new Personaje("Frodo", "Hobit");
            var legolas = new Personaje("Legolas", "Elfo");

            ProcesandoCadenasDeTexto vozDeFrodo, vozDeLegolas, background;

            vozDeFrodo = new ProcesandoCadenasDeTexto(frodo.PalabrasDelPersonaje);
            vozDeLegolas = new ProcesandoCadenasDeTexto(legolas.PalabrasDelPersonaje);
            background = new ProcesandoCadenasDeTexto(SonidoDeFondo.NotaDelNarrador);

            vozDeFrodo("Todo lo que tenemos que decidir es qué hacer con el tiempo que se nos da.");
            vozDeLegolas("¿Y que hay del lado de un amigo?");
            background("Se escuchan leves pasos.");

            Console.WriteLine(vozDeFrodo);
            Console.ReadLine();

        }
    }
}


