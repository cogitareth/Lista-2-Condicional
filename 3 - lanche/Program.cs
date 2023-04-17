using System;

class programa
{
    static void Main(string[] args)
    {
        double preco1 = 0;
        double preco2 = 0;

        string[] pedido = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(pedido[0]);
        int cod2 = int.Parse(pedido[1]);

        if (cod1 == 1)
        {
            preco1 = 4.00;
        }

        else if (cod1 == 2)
        {
            preco1 = 4.50;
        }

        else if (cod1 == 3)
        {
            preco1 = 5.00;
        }

        else if (cod1 == 4)
        {
            preco1 = 2.00;
        }

        else if (cod1 == 5)
        {
            preco1 = 1.50;
        }

        if (cod2 == 1)
        {
            preco2 = 4.00;
        }

        else if (cod2 == 2)
        {
            preco2 = 4.50;
        }

        else if (cod2 == 3)
        {
            preco2 = 5.00;
        }

        else if (cod2 == 4)
        {
            preco2 = 2.00;
        }

        else if (cod2 == 5)
        {
            preco2 = 1.50;
        }

        double precoFinal = preco1 + preco2;

        Console.WriteLine($"Total: R$ {precoFinal.ToString("f2")}");
    }
}