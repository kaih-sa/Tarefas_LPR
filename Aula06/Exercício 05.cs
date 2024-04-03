// // Aula 06 andery ex5
using System;
class ex5
{
    static void Main()
    {
        float horas_por_dia;
        float soma_horas = 0;
        int dias_passados = 0;
        float semanas;
        float meses;
     
        Console.Write("Digite o número de horas de treinamento por dia: ");
        horas_por_dia = float.Parse(Console.ReadLine());

      
        while (soma_horas < 1000)
        {
            soma_horas += horas_por_dia;
            dias_passados++;
        }

        semanas = dias_passados / 5;
        meses = semanas / 4.5f;

        Console.WriteLine($" Dias necessários para concluir 1000 horas: {dias_passados}");
        Console.WriteLine($" Semanas necessárias para concluir 1000 horas: {semanas}\n Meses necessários para concluir 1000 horas: {meses} ");

    }
}