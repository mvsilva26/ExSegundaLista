using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar se ele é primo ou não: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int compara = 0;
        
            for (int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    compara++;
                }
                                     
            }
            if (compara == 0)
            {
                Console.WriteLine("{0} é primo", n);
            }
            else
            {
                Console.WriteLine("{0} não é primo", n);
            }


        }
    }
}
