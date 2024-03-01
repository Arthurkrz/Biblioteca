using System;

namespace Biblioteca
{
    class Valorcarro
    {
        public static void Exercicio6()
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite o valor do veículo ou digite 'E' para sair: ");
                string inputvalor = Console.ReadLine();
                if (double.TryParse(inputvalor, out double valorinicial) && valorinicial > 0)
                {
                    for (int i = 6; i <= 60; i += 6)
                    {
                        double valorparcela = i * 0.03;
                        string sep = new string('-', 10);
                        Console.WriteLine($"Valor em {i} parcelas: {valorinicial + valorparcela}.");
                        Console.WriteLine($"{sep}");
                    }
                    double avista = valorinicial * 0.02;
                    Console.WriteLine($"Valor do veículo à vista: {valorinicial - avista}.");
                }
                if (inputvalor == "E" || inputvalor == "e")
                {
                    controle = false;
                }
                else
                {
                    Console.WriteLine("Valor inválido. Favor digitar um número inteiro maior que zero.");
                }
            }
        }
    }
}