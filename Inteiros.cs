using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Inteiros
    {
        public static void Exercicio4()
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite os valores inteiros separados por vírgula (X,Y,Z,...) ou digite 'E' para sair: ");
                string input = Console.ReadLine();
                string[] valores = input.Split(',');
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Nenhum valor foi inserido.");
                    continue;
                }
                List<int> numerosValidos = new List<int>();
                int dentroIntervalo = 0;
                int foraIntervalo = 0;
                foreach (string valor in valores)
                {
                    if (input == "E" || input == "e")
                    {
                        controle = false;
                    }
                    if (int.TryParse(valor, out int num) && (input.ToLower() != "e"))
                    {
                        numerosValidos.Add(num);
                        if (num >= 10 && num <= 20)
                        {
                            dentroIntervalo++;
                        }
                        else
                        {
                            foraIntervalo++;
                        }
                    }
                    else if (input.ToLower() != "e")
                    {
                        Console.WriteLine($"Valor '{valor}' inválido.");
                    }
                }
                if (input.ToLower() != "e")
                {
                    Console.WriteLine($"{dentroIntervalo} in.");
                    Console.WriteLine($"{foraIntervalo} out.");
                }
            }
        }
    }
}
