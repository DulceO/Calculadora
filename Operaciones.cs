using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLab
{
    class Operaciones
    {
        private int a = 0;
        private int b = 0;

        public int Suma(int n1, int n2)
        {
            a = n1;
            b = n2;
            return (a + b);
        }

        public int Resta(int n1, int n2)
        {
            a = n1;
            b = n2;
            return (a - b);
        }
        public int Multiplicación(int n1, int n2)
        {
            a = n1;
            b = n2;
            return (a * b);
        }
        public int División(int n1, int n2)
        {
            a = n1;
            b = n2;
            return (a / b);
        }
    }
}
