using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
                    
            Console.WriteLine("Digite um número de 1 a 9 para ver a tabuada: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 9)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i + " x " + num + " = " + i * num);
                }
            }
            else
            {
                Console.WriteLine("Digite um número de 1 a 9");
            }
                        
        }
    }
}
