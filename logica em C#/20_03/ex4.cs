using System;

class Program
{
    public static void Main(string[] args)
    {


        /* Escreva um programa que entre com três números e determine
        se  eles formam ou não um triângulo válido ou não.
        Um triângulo é válido se a soma de quaisquer dois lados for maior que o terceiro lado.
        */
        Console.Write("Digite o primeiro número: ");
        int lado1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int lado2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro número: ");
        int lado3 = int.Parse(Console.ReadLine());
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            Console.WriteLine("Os segmentos podem formar um triângulo");
        else
            Console.WriteLine("Os segmentos não  podem formar um triângulo");
    }


    }
