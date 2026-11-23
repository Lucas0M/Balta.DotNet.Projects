using System;

namespace Balta.DotNet.Projects.MyApp;

class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid();
        id.ToString();

        id = new Guid();
        
        Console.Write(id);
    }
}