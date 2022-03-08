using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int aux;


            Console.WriteLine("Digite um número paraa sequência de Fibonacci: ");
            int n = Convert.ToInt32(Console.ReadLine());    
            for(int i = 0; i < n; i++)
            {
                aux = a + b;
                a = b;
                b = aux;
                Console.WriteLine("{0}", aux);
            }
            //Console.WriteLine("{0}", aux);
        }
    }
}
