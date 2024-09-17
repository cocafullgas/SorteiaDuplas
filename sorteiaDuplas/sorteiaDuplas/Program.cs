using System;
using static System.Console;
using System.Threading;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                WriteLine("Quantas Pessoas irão participar? ");
                int n = int.Parse(ReadLine());
                if (n % 2 == 1)
                {
                    WriteLine("O número de pessoas deve ser par");
                    Thread.Sleep(2000);
                }

                List<string> nomes = new List<string>();

                for (int i2 = 0; i2 < n; i2++)
                {
                    WriteLine($"Digite o {i2 + 1} °nome");
                    string nome = ReadLine();
                    nomes.Add(nome);
                }

                string[,] duplas = new string[n / 2, 2];
                Random random = new Random();
                

                // o primeiro for serve como o geral o segundo sorteia a linha
                for (int i = 0; i < n / 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int ind = random.Next(nomes.Count);
                        duplas[i, j] = nomes[ind];
                        nomes.RemoveAt(ind);

                    }
                }

                for (int i = 0; i < n/2; i++)
                {
                    WriteLine($"\nDupla{i+1}: {duplas[i,0]} e {duplas[i, 1]} ");
                    Thread.Sleep(500);
                }
                ReadKey();

            }
        }
    }
}