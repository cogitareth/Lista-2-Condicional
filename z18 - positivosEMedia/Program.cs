using System;

namespace ContagemPositivosEMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            int positivos = 0;
            double somaPositivos = 0;

            for (int i = 0; i < 6; i++)
            {
                double valor = Convert.ToDouble(Console.ReadLine());

                if (valor > 0)
                {
                    positivos++;
                    somaPositivos += valor;
                }
            }

            double mediaPositivos = somaPositivos / positivos;

            Console.WriteLine(positivos + " valores positivos");
            Console.WriteLine(mediaPositivos.ToString("F1"));
        }
    }
}