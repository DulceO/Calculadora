using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLab
{
    class Program
    {
        static Menu m = new Menu();
        static Operaciones sr = new Operaciones();
        static void Main(string[] args)
        {
            int op = 0;

            while ((op = m.ListaMenu()) != m.n.Length)
            {
                if (op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("La suma es: " + sr.Suma(m.Mensaje("primer valor a sumar"), m.Mensaje("segundo valor a sumar")));
                    Console.ReadKey();
                    Console.Clear();

                }

                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("La resta es: " + sr.Resta(m.Mensaje("primer valor a restar"), m.Mensaje("segundo valor a restar")));
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("La Multiplicación es: " + sr.Multiplicación(m.Mensaje("primer valor a multiplicar"), m.Mensaje("segundo valor a multiplicar")));
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (op == 4)
                {
                    Console.Clear();
                    Console.WriteLine("La División es: " + sr.División(m.Mensaje("primer valor a dividir"), m.Mensaje("segundo valor a dividir")));
                    Console.ReadKey();
                    Console.Clear();

                }

                else
                {
                    Console.WriteLine("Opción no valida");
                    Console.ReadKey();
                    Console.Clear();
                }



            }

        }
    }
}
