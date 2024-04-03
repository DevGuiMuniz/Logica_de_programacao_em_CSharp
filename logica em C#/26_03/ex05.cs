using System;

class Program
{
    public static void Main(string[] args)
    {

        // Inverter um Número inteiro


        Console.WriteLine("\nExercicio 5");
        double num2 = 123456;
        double invertido = 0;
        while (num2 >= 1)
        {

            double digitoAtual = num2 % 10;
            invertido = invertido * 10 + digitoAtual;
            num2 = Math.Floor(num2 / 10);
        }
        Console.WriteLine(invertido);



        /*  2 OPÇÃO DE RESOLUÇÃO
        
        double numm=123456;
          double resto = 1;
          while (numm > 0){
            resto = numm % 10;
            invertido += resto;
            numm = Math.Floor(numm/10);
           invertido *= 10;
          }
          */

    }
}