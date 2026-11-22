using System;

namespace Balta.DotNet.Projects.Calculator
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
            Console.WriteLine("Calculadora");
            Console.WriteLine("------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Divisao");
            Console.WriteLine("4 - Multiplicacao");
            Console.WriteLine("5 - Par ou Impar");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("------------");
            
            Console.Write("Selecione uma opcao: ");
            
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 0:
                    Sair();
                    break;
                case 5:
                    ParOuImpar();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            // Limpar Console
            Console.Clear();
            
            // Pega primeiro val
            Console.Write("Primeiro Valor: ");
            double v1 = Double.Parse(Console.ReadLine());
            
            // Pega segundo val
            Console.Write("Segundo Valor: ");
            double v2 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double result = v1 + v2;
            
            Console.WriteLine($"Resultado da soma: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            // Limpar Console
            Console.Clear();
            
            // Pega primeiro val
            Console.Write("Primeiro Valor: ");
            double v1 = Double.Parse(Console.ReadLine());
            
            // Pega segundo val
            Console.Write("Segundo Valor: ");
            double v2 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double result = v1 - v2;
            
            Console.WriteLine($"Resultado da subtracao: {result}");
            Console.ReadKey();
            Menu();
        }
        
        static void Divisao()
        {
            // Limpar Console
            Console.Clear();
            
            // Pega primeiro val
            Console.Write("Primeiro Valor: ");
            double v1 = Double.Parse(Console.ReadLine());
            
            // Pega segundo val
            Console.Write("Segundo Valor: ");
            double v2 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double result = v1 / v2;
            
            Console.WriteLine($"Resultado da divisao: {result}");
            Console.ReadKey();
            Menu();
            
        }

        static void Multiplicacao()
        {
            Console.Clear();
            
            Console.Write("Digite o primeiro valor: ");
            double v1 = Double.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo valor: ");
            double v2 = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            double result = v1 * v2;
            
            Console.WriteLine($"Resultado da multiplicacao: {result}");
            Console.ReadKey();
            Menu();
            
        }

        static void ParOuImpar()
        {
            Console.Clear();
            
            Console.Write("Digite um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());
            
            if (valor % 2 == 0)
            {
                Console.WriteLine($"O valor {valor} é Par");
                Console.ReadKey();
                Menu();
            }
            
            Console.WriteLine($"O valor {valor} é Impar");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}

