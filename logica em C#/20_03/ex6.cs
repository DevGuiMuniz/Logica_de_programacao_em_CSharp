using System;

class Program
{
    public static void Main(string[] args)
    {


        /* Teste se um número entre 1 e 3000 é um ano bissexto ou não.
        Um ano é bissexto se for divisivel por 4 e não for divisil por 100, exceto se for divísel por 400
        */

        Console.Write("Digite um ano entre 1 e 3000: ");
        int ano = int.Parse(Console.ReadLine());
        if (ano < 1 || ano > 3000)
        {
            Console.WriteLine("O ano deve ser entre 1 e 3000.");
        }
        else if (ano % 400 == 0)
        {
            Console.WriteLine($"O {ano} é Bissexto");
        }
        else if (ano % 100 == 0)
        {
            Console.WriteLine($"O {ano} Não é Bissexto");
        }
        else if (ano % 4 == 0)
        {
            Console.WriteLine($"O {ano} é Bissexto");
        }
        else
        {
            Console.WriteLine($"O{ano} Não é bissexto");
        }
    }
}