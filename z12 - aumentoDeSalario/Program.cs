using System;

class Program
{
    static void Main(string[] args)
    {
        double salario = double.Parse(Console.ReadLine());

        double novoSalario, valorReajuste;
        int indiceReajuste;

        if (salario <= 400.00)
        {
            indiceReajuste = 15;
            valorReajuste = salario * 0.15;
        }
        else if (salario <= 800.00)
        {
            indiceReajuste = 12;
            valorReajuste = salario * 0.12;
        }
        else if (salario <= 1200.00)
        {
            indiceReajuste = 10;
            valorReajuste = salario * 0.10;
        }
        else if (salario <= 2000.00)
        {
            indiceReajuste = 7;
            valorReajuste = salario * 0.07;
        }
        else
        {
            indiceReajuste = 4;
            valorReajuste = salario * 0.04;
        }

        novoSalario = salario + valorReajuste;

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
        Console.WriteLine("Reajuste ganho: " + valorReajuste.ToString("F2"));
        Console.WriteLine("Em percentual: " + indiceReajuste + " %");

    }
}