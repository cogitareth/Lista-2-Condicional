using System;

class programa
{
    static void Main(string[] args)
    {
        string var1 = Console.ReadLine();
        string var2 = Console.ReadLine();
        string var3 = Console.ReadLine();

        if (var1 == "vertebrado")
        {
            if (var2 == "ave")
            {
                if (var3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }
                else
                {
                    Console.WriteLine("pomba");
                }
            }

            else if (var2 == "mamifero")
            {
                if (var3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }
                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }

        else if (var1 == "invertebrado")
        {
            if (var2 == "inseto")
            {
                if (var3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }
                else
                {
                    Console.WriteLine("lagarta");
                }
            }

            else if (var2 == "anelideo")
            {
                if (var3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }
                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}