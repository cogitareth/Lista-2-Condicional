using System;

class programa
{
    static void Main(string[] args)
    {
        string[] notas = Console.ReadLine().Split(' ');
        double nota1 = double.Parse(notas[0]);
        double nota2 = double.Parse(notas[1]);
        double nota3 = double.Parse(notas[2]);
        double nota4 = double.Parse(notas[3]);

        double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 4) + (nota4 * 1)) / 100;

        Console.WriteLine("Media: "+ media.ToString("f1"));

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }

        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }

        else if (media < 7.0 & media >= 5.0)
        {
            Console.WriteLine("Aluno em exame.");
            double notaDoExame = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: " + (notaDoExame / 10));

            double mediaFinal = ((notaDoExame / 10) + media) / 2;

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine("Media final: " + mediaFinal);
        }
    }
}