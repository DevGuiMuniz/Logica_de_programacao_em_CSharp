using System;

class Program
{
    public static void Main(string[] args)
    {

        // Calcular a série Fibonacci at´o N-ésimo termo

        Console.WriteLine("\nExercicio 7");
        Console.WriteLine("Digite um Número Inteiro:");
        int termos = int.Parse(Console.ReadLine());
        int penultimo = 0;
        int ultimo = 1;
        int atual = penultimo + ultimo;
        Console.WriteLine(penultimo);
        Console.WriteLine(ultimo);
        // contador = "i"
        for (int i = 3; i <= termos; i++)
        {

            Console.WriteLine(atual);
            penultimo = ultimo;
            ultimo = atual;
            atual = ultimo + penultimo;
        }

    }

}