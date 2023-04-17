using System;

class programa
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0]);
        double b = double.Parse(valores[1]);
        double c = double.Parse(valores[2]);

        if ((a + b) > c || (b + c) > a || (a+ c) > b)
        {
            Console.WriteLine(a + b + c);
        }

        else
        {
            Console.WriteLine("Perimetro = " + ((a + b) * c) / 2);
        }

    }
}