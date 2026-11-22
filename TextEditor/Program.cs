using System;

namespace Balta.DotNet.Projects.TextEditor
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
            Console.WriteLine("Editor de Texto");
            Console.WriteLine("------------");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine("------------");
            Console.Write("Qual escolha deseja escolher: ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Abrir()
        {
            
        }

        static void Editar()
        {
            
        }
    }
}

