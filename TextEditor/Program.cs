using System;
using System.IO;

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
                    Criar();
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
            Console.Clear();
            Console.Write("Qual o caminho do arquivo: ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            
            Console.ReadLine();
            Menu();
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("------------");
            Console.WriteLine("Digite seu texto (ESC para sair): ");
            Console.WriteLine("------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.Write("Qual caminho deseja salvar o arquivo: ");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            
            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Console.ReadLine();
            Menu();
        }
    }
}

