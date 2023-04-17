using System;

class Program
{
    static void Main(string[] args)
    {
        string[] linha = Console.ReadLine().Split(' ');
        double A = double.Parse(linha[0]);
        double B = double.Parse(linha[1]);
        double C = double.Parse(linha[2]);

        double temp;
        if (A < B)
        {
            temp = A;
            A = B;
            B = temp;
        }
        if (A < C)
        {
            temp = A;
            A = C;
            C = temp;
        }
        if (B < C)
        {
            temp = B;
            B = C;
            C = temp;
        }

        if (A >= B + C)
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else if (A * A == B * B + C * C)
        {
            Console.WriteLine("TRIANGULO RETANGULO");
        }
        else if (A * A > B * B + C * C)
        {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        }
        else if (A * A < B * B + C * C)
        {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        }

        if (A == B && B == C)
        {
            Console.WriteLine("TRIANGULO EQUILATERO");
        }
        else if (A == B || B == C || A == C)
        {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }
    }
}