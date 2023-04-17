using System;

namespace ContagemValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < 5; i++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor % 2 == 0)
                    pares++;
                else
                    impares++;

                if (valor > 0)
                    positivos++;

                else if (valor < 0)
                    negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");
        }
    }
}