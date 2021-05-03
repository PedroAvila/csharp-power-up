using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp00_PowerUp
{
    class Delegados
    {
    }

    public class Personaje
    {
        public string Raza { get; set; }
        public string Nombre { get; set; }

        public Personaje(string nombre, string raza)
        {
            this.Nombre = nombre;
            this.Raza = raza;
        }

        public void PalabrasDelPersonaje(string mensaje)
        {
            Console.WriteLine($"{Nombre} dice: {mensaje}");
        }
    }

    static class SonidoDeFondo
    {
        public static void NotaDelNarrador(string nota)
        {
            Console.WriteLine($"({nota})");
        }
    }
}
