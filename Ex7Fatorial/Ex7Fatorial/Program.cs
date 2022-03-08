using System;

namespace Ex7Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber seu fatorial: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fat = 1;
            
            
            while (n > 1)
            {
                fat *= n;
                n--;
            }
            Console.WriteLine(fat);
            

            
            /*
            for(int i = n; i > 1; i--)
            {
                fat *= i;
            }
            Console.WriteLine(fat);
            */
            

        }
    }
}
