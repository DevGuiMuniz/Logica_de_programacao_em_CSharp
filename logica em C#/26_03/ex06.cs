using System;

class Program
{
    public static void Main(string[] args)
    {

        // Calcular o Fatorial de um número




        Console.WriteLine("\nExercicio 6");
        Console.Write("Digite um número inteiro:");
        int num3 = int.Parse(Console.ReadLine());
        int fatorial = 1;

        for (int i = 1; i <= num3; i++)
        {
            fatorial *= i;
        }
        Console.WriteLine($"O fatorial de {num3} é {fatorial}");


    }

}