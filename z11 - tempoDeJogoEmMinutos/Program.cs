using System;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(entrada[0]);
        int minutoInicial = int.Parse(entrada[1]);
        int horaFinal = int.Parse(entrada[2]);
        int minutoFinal = int.Parse(entrada[3]);

        int duracaoEmMinutos;
        if (horaInicial < horaFinal || (horaInicial == horaFinal && minutoInicial <= minutoFinal))
        {
            duracaoEmMinutos = (horaFinal - horaInicial) * 60 + (minutoFinal - minutoInicial);
        }
        else
        {
            duracaoEmMinutos = (24 - horaInicial + horaFinal) * 60 + (minutoFinal - minutoInicial);
        }

        if (duracaoEmMinutos < 0)
        {
            duracaoEmMinutos += 24 * 60;
        }

        int duracaoHoras = duracaoEmMinutos / 60;
        int duracaoMinutos = duracaoEmMinutos % 60;

        Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");

    }
}