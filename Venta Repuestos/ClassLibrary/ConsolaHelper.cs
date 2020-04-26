using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            string n = Console.ReadLine();
            string chequeo = Validaciones.ValidarString(n);
            if (chequeo == "")
            {
                throw new Exception("El valor ingresado no es válido.");
            }
            else
            {
                return n;
            }
        }

        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            int c = Validaciones.ValidarInt(Console.ReadLine());
            if (c < 0)
            {
                throw new Exception("El valor ingresado no es válido.");
            }
            else
            {
                return c;
            }
        }
        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            double c = Validaciones.ValidarDouble(Console.ReadLine());
            if (c < 0)
            {
                throw new Exception("El valor ingresado no es válido.");
            }
            else
            {
                return c;
            }
        }
        /*public static Categoria PedirCategoria(string msg)
        {
            int cod = PedirInt("Código de categoría.");
            string n = PedirString("Nombre de categoría.");
            Categoria cat = new Categoria(cod, n);
            return cat;
        }*/
        public static bool EsOpcionValida(string input, string opcionesValidas)
        {
            try
            {
                if (string.IsNullOrEmpty(input) || input.Length > 1|| !opcionesValidas.ToUpper().Contains(input.ToUpper()))
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
