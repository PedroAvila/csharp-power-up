using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_MetodosExtension
{
    public static class Extensores
    {
        public static int ContarPalabras(this string texto)
        {
            return texto.Split(' ').Length;
        }

        public static string Combinar<T>(this IEnumerable<T> ien)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item in ien)
            {
                sb.Append(item.ToString());
            }
            return sb.ToString();
        }
    }
}
