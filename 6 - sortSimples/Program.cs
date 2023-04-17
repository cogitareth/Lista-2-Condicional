using System;

class programa
{
    static void Main(string[] args)
    {
    string[] sequencia = Console.ReadLine().Split(' ');
    int valor1 = int.Parse(sequencia[0]);
    int valor2 = int.Parse(sequencia[1]);
    int valor3 = int.Parse(sequencia[2]);

    int[] valoresOrdenados = { valor1, valor2, valor3 };
    Array.Sort(valoresOrdenados);

    foreach(int valor in valoresOrdenados)
    {
        Console.WriteLine(valor);
    }

    Console.WriteLine();
    Console.WriteLine(valor1);
    Console.WriteLine(valor2);
    Console.WriteLine(valor3);

    }
}