using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
        personagem Tony = new personagem();
         
        Console.WriteLine(Tony.nome);
        Console.WriteLine(Tony.idade);
         Console.WriteLine( Tony.atacarFraco(34.5f, 20f));

        }
        
        }
       
    
}