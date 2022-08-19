using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace materiaQuinta
{
    internal class Program
    {
        //Aula do dia 18.08
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var fibonacci = new Fibonacci(x);

            IList<int> listMenor = new List<int>();
            IList<int> listMaior = new List<int>();
            var numeros = fibonacci.FibonacciMetodo();

            foreach (int numero in numeros)
            {
                if(numero > x)
                {
                    listMaior.Add(numero);
                }
                else
                {
                    listMenor.Add(numero);
                }                
            }
            Console.WriteLine($"Menor que: {x}");
            foreach (int numero in listMenor)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("=========================");
            Console.WriteLine($"Maior que: {x}");
            foreach (int numero in listMaior)
            {
                    Console.WriteLine(numero);
            }
           Console.ReadLine();
        }


    }
}
