using System;

class Program
{
    public static void Main(string[] args)
    {


        /* A partir de 3 notas, calcule a media e informe se a pessoa foi aprovada 
        (media >=6) ou reprovada (media <6)
        */

        Console.Write("Digite a nota 1:");
        int nota1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2:");
        int nota2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3:");
        int nota3 = int.Parse(Console.ReadLine());
        double media = (nota1 + nota2 + nota3) / 3;

        if (media >= 6)
        {
            Console.WriteLine($" A sua Media foi {media} e você foi aprovado!");

        }
        else (media < 6){
            Console.WriteLine($"A sua Media foi {media} e infelizmente você está reprovado!");
        }
    }
}