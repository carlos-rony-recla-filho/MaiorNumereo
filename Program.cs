using System;

namespace MaiorNumereo
{
    class Program
    {
        static void Main(string[] args)
    {
            int primeiro, segundo, MaiorNumero;
            
            Console.Write("Digite o primeiro número....:");
            primeiro = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o segundo número.....:");
            segundo = Convert.ToInt32(Console.ReadLine());

            if (primeiro > segundo)
            {
                MaiorNumero = primeiro;
            }
            else
            {
                MaiorNumero = segundo;
            }   
            Console.WriteLine($"o Maior Número é {MaiorNumero}"); 
       }
    }   
}    