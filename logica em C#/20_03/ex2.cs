using System;

class Program
{
    public static void Main(string[] args)
    {


        // A partir de um número entre 1 e 7, imprima o dia da semana correspondente

        Console.Write("Digite um Número entre 1 e 7");
        int dia = int.Parse(Console.ReadLine());

        if (dia == 1)
            Console.WriteLine("Domingo");

        else if (dia == 2)
            Console.WriteLine("Segunda");
        else if (dia == 3)
            Console.WriteLine("Terça");
        else if (dia == 4)
            Console.WriteLine("Quarta");
        else if (dia == 5)
            Console.WriteLine("Quinta");
        else if (dia == 6)
            Console.WriteLine("Sexta");
        else if (dia == 7)
            Console.WriteLine("Sabado");



    }
}
