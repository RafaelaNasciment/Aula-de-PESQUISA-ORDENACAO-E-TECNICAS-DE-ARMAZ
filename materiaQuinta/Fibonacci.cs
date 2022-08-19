using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materiaQuinta
{
    public class Fibonacci
    {
        public Fibonacci(int numeroDesejado)
        {
            NumeroDesejado = numeroDesejado;
        }

        public int NumeroDesejado { get; set; }
        public IList<int> FibonacciMetodo()
        {
            var x = NumeroDesejado;
            IList<int> retorno = new List<int>();

            var num1 = 0;
            var num2 = 1;
            var aux = 0;    
            var i = 0;

            while (i < x)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                i++;
                retorno.Add(num2);
            }

            return retorno;
        }
    }
}
