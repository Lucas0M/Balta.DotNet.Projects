using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------");
            Console.WriteLine("Stopwatch");
            Console.WriteLine("------------");
            Console.WriteLine("Rules");
            Console.WriteLine("S = Segundos (10s)");
            Console.WriteLine("M = Minutos (1m)");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("------------");
            Console.Write("Qual opcao deseja escolher: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
        }
    }
}

