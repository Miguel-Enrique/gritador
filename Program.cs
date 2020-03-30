using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite algo para mim gritar");
            string texto;
            texto = Console.ReadLine();
            Console.WriteLine(texto.ToUpper());
            Console.WriteLine(texto);
            
        }
    }
}
