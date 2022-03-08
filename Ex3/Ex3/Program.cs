using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int somaPar = 0;
            int somaImpar = 0;
            while(n <= 1000)
            {
                Console.WriteLine("Digite um número: ");
                n = Convert.ToInt32(Console.ReadLine());

                if(n <= 1000)
                {
                    if (n % 2 == 0)
                    {
                        somaPar += n;
                    }
                    else
                    {
                        somaImpar += n;
                    }
                }
                
                
            }
            Console.WriteLine("Soma dos pares: {0}", somaPar);
            Console.WriteLine("Soma dos ímpares: {0}", somaImpar);





        }
    }
}
