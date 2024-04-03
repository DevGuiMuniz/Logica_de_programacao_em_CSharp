using System;

class Program
{
    public static void Main(string[] args)
    {


        // Calcular a potência de um número sem usar a função Math.Pow() 
        Console.WriteLine("\nExercicio 2");
        Console.Write("Digite um número inteiro:");
        int t = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i += 1)
        {
            int resultado = t * i;
            Console.WriteLine($"{t} x {i} = {resultado}");
        }

    }
}