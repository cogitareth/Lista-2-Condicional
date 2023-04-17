using System;

namespace ContagemPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;

            for (int i = 0; i < 5; i++)
            {
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor % 2 == 0)
                    pares++;
            }

            Console.WriteLine(pares + " valores pares");
        }
    }
}