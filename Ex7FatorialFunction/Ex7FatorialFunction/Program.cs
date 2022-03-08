using System;

namespace Ex7FatorialFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int num, resp;
            Console.WriteLine("Informe o valor: ");
            num = int.Parse(Console.ReadLine());

            resp = fat(num);

            Console.WriteLine("O fatorial de {0} é: {1}", num, resp);
            
        }

        static int fat(int num)
        {
            if(num == 0)
            {
                return 1;
            }
            else
            {
                return (fat(num - 1) * num);
            }
        }

        
    }
}
