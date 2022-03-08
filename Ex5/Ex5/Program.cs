using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasDecorridos = 0;
            int anosBissextos = 0;
            Console.WriteLine("Digite o ano mais antigo: ");
            int anoAnt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o ano mais recente: ");
            int anoRec = Convert.ToInt32(Console.ReadLine());

            if(anoAnt > anoRec)
            {
                int aux = anoAnt;
                anoAnt = anoRec;
                anoRec = aux;
            }

            for(int ano = anoAnt; ano < anoRec; ano++)
            {
                if(ano % 400 == 0 || ano % 4 == 0 && ano % 100 == 0)
                {
                    string message = (DateTime.Now.Year > ano)
                        ? $"\n{ano} foi um ano bissexto."
                        : $"\n{ano} será um ano bissexto";

                    Console.WriteLine(message);
                    diasDecorridos += 366;
                    anosBissextos++;


                }
                else
                {
                    diasDecorridos += 366;
                }
            }
            Console.WriteLine("\nAno mais antigo: {0}", anoAnt);
            Console.WriteLine("\nAno mais recente: {0}", anoRec);
            Console.WriteLine("\nAnos decorridos: {0}", anoRec - anoAnt);
            Console.WriteLine("\nAno bissextos: {0}", anosBissextos);
            Console.WriteLine("\nDias decorridos: {0}", diasDecorridos);

            Console.ReadKey();

        }
    }
}
