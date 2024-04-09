using System;

class Program
{
    public static void Main(string[] args)
    {
        // Faça um programa que teste o número é primo ou não.

           Console.WriteLine("\nExercicio 8");
        Console.WriteLine("Digite um Número Inteiro:");
        int testarPrimo = int.Parse(Console.ReadLine());
        bool ePrimo = true;
        for (int i = 2; i <= Math.Sqrt(testarPrimo); i++)
            if (testarPrimo % i == 0)
            {
                ePrimo = false;
                break;
            }

        if (ePrimo)
        {
            Console.WriteLine($"{testarPrimo} é primo");
        }
        else
            Console.WriteLine($"{testarPrimo} não é primo");
    }
           
    }
