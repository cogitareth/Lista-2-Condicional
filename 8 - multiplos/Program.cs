using System;

class program
{
    static void Main(string[] args)
    {
        string[] linha = Console.ReadLine().Split(' ');
        int A = int.Parse(linha[0]);
        int B = int.Parse(linha[1]);

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("Sao Multiplos");
        }

        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }
}