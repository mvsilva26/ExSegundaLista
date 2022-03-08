using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[] vet = new float[15];
            float maior = 0;
            float menor = 0;

            
            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º valor");
                vet[i] = float.Parse(Console.ReadLine());

                if(i == 0)
                {
                    maior = vet[i];
                    menor = vet[i];
                }
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
            }
            Console.WriteLine("O menor valor é: {0}", menor);
            Console.WriteLine("O maior valor é: {0}", maior);

        }
    }
}
