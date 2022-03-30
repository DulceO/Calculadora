using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLab
{
    class Menu
    {
        public int opcion = 0;
        private char salir = 's';
        public string[] n = new string[] { "Suma", "Resta", "Multiplicación", "División", "Salir" };



        public int ListaMenu()
        {

            for (int x = 0; x < n.Length; x++)
            {

                Console.WriteLine((x + 1) + ".-" + n[x]);

            }


            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());
            return opcion;

        }

        public int Mensaje(string msn)
        {
            Console.WriteLine("Ingrese, " + msn + ":");
            return int.Parse(Console.ReadLine());

        }
    }
}
