using System;

class Program
{
    public static void Main(string[] args)
    {


        // Somar os primeiros 20 números pares.

        Console.WriteLine("\nExercicio 3");
        int soma = 0;
        for (int contador = 0; contador < 20; contador++)
        {
            soma = soma + contador * 2;
        }
        Console.WriteLine(soma);
    }
}