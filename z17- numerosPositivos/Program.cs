using System;

namespace QuantidadeValoresPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;

            for (int i = 0; i < 6; i++)
            {
                double valor = Convert.ToDouble(Console.ReadLine());

                if (valor > 0)
                {
                    positivos++;
                }
            }

            Console.WriteLine(positivos + " valores positivos");
        }
    }
}
