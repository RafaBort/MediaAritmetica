using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a média aritmética, fale os 3 números...");

            Console.WriteLine("Digite o primeiro número...");
            string número1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo número...");
            string número2 = Console.ReadLine();

            Console.WriteLine("Digite o terceiro número...");
            string número3 = Console.ReadLine();

            Double N1 = Convert.ToDouble(número1);
            Double N2 = Convert.ToDouble(número2);
            Double N3 = Convert.ToDouble(número3);

            Double média = N1 + N2 + N3;
            Double média1 = média / 3;
            Console.WriteLine("A Média Aritmética é... " + média1);


        }
    }
}
