using System;
using System.Collections.Generic;

namespace ConsoleApp00_PowerUp
{
    // Crear el delegado
    delegate void ProcesandoCadenasDeTexto(string input);
    public delegate bool _delegadoDelFiltro(Personaje p);

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Net University | ASP.net Core 3 | C# Power Up!";
            Console.WriteLine("Loading... Please Wait... Loaded!");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Aprendiendo Delegates");
            Console.WriteLine(Environment.NewLine);

            var frodo = new Personaje("Frodo", "Hobbit");
            var legolas = new Personaje("Legolas", "Elfo");

            ProcesandoCadenasDeTexto vozDeFrodo, vozDeLegolas, background;

            vozDeFrodo = new ProcesandoCadenasDeTexto(frodo.PalabrasDelPersonaje);
            vozDeLegolas = new ProcesandoCadenasDeTexto(legolas.PalabrasDelPersonaje);
            background = new ProcesandoCadenasDeTexto(SonidoDeFondo.NotaDelNarrador);

            vozDeFrodo("Todo lo que tenemos que decidir es qué hacer con el tiempo que se nos da.");
            vozDeLegolas("¿Y que hay del lado de un amigo?");
            background("Se escuchan leves pasos.");

            var arwen = new Personaje("Arwen", "Elfo");
            var gimli = new Personaje("Gimli", "Enano");
            var aragorn = new Personaje("Aragorn", "Humano");
            var gandalf = new Personaje("Gandalf", "Mago");
            var saruman = new Personaje("Saruman", "Mago");
            var sam = new Personaje("Sam", "Hobbit");
            var boromir = new Personaje("Boromir", "humano");
            var elrond = new Personaje("Elrond", "elfo");
            var eldelrack = new Personaje("Eldelrack", "elfo");

            var personajesLOTRO = new List<Personaje>()
            {
                frodo, legolas, arwen, gimli, aragorn, gandalf, saruman, sam, boromir, elrond, eldelrack
            };

            //Console.WriteLine(vozDeFrodo);

            MostrarPersonajes("Humanos", personajesLOTRO, delegate (Personaje x) { return x.Raza.Equals("humano", StringComparison.OrdinalIgnoreCase); });

            MostrarPersonajes("Enanos", personajesLOTRO, x => x.Raza.Equals("enano", StringComparison.OrdinalIgnoreCase));

            MostrarPersonajes("Hobbits", personajesLOTRO, EsHobbit);

            MostrarPersonajes("Magos", personajesLOTRO, EsMago);

            MostrarPersonajes("Elfos", personajesLOTRO, EsElfo);
            Console.ReadLine();

        }

        static void MostrarPersonajes(string nombreDelFiltro, List<Personaje> listaDePersonajes, _delegadoDelFiltro filtro)
        {
            Console.WriteLine($"Filtrando por: {nombreDelFiltro}");
            foreach (var personaje in listaDePersonajes)
            {
                if (filtro(personaje))
                {
                    Console.WriteLine($"{personaje.Nombre} es {personaje.Raza}");
                }
            }
            Console.WriteLine(Environment.NewLine);

        }

        static bool EsHobbit(Personaje pe)
        {
            return pe.Raza.Equals("hobbit", StringComparison.OrdinalIgnoreCase);
        }

        static bool EsMago(Personaje pe)
        {
            return pe.Raza.Equals("mago", StringComparison.OrdinalIgnoreCase);
        }

        static bool EsElfo(Personaje personaje)
        {
            return personaje.Raza.Equals("elfo", StringComparison.OrdinalIgnoreCase);
        }
    }
}


