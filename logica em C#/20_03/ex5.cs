using System;

class Program
{
    public static void Main(string[] args)
    {


        /* Teste se um número é um múltiplo de 3 e 5 ao mesmo tempo
        */

        Console.Write("Digite algum número para fazer a verificação: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 3 == 0 && n % 5 == 0)
        {
            Console.WriteLine($"{n} é mutiplo de 3 e 5 simultaneamente");
        }
        else
        {
            Console.WriteLine($"{n} não é mutiplo de 3 ou 5");
        }
    }
}