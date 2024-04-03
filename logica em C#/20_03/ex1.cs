
using System;

class Program
{
    public static void Main(string[] args)
    {

        // Teste se um número é positivo ou negativo e informe o resultado no console

        Console.Write("Digite um Número para fazer a verificação:");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {

            Console.WriteLine($"O {num} é um valor positivo!");

        }
        else if (num = 0)
        {
            Console.WriteLine($"O valor {num} é igual a zero!");
        }
        else (num < o){
            Console.WriteLine($"O {num} é um valor negativo!");
        }


    }
}