using System;

class Program
{
    public static void Main(string[] args)
    {

        // Contar o número de digitos em um número inteiro.

        Console.WriteLine("\nExercicio 4");
        int num = 546821354;
        int numeroDeDigitos = 0;
        while (num >= 1)
        {
            num /= 10;
            numeroDeDigitos++;
        }
        Console.WriteLine(numeroDeDigitos);


    }
}