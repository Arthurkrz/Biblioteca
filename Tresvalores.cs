using System;

namespace Biblioteca
{
    class Tresvalores
    {
        public static void Exercicio5()
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Insira um número inteiro ou digite 'E' para sair: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "e")
                {
                    controle = false;
                }
                else if (int.TryParse(input, out int numtestes) && numtestes > 0)
                {
                    Random random = new Random();
                    Console.WriteLine(new string('-', 30));
                    for (int i = 0; i < numtestes; i++)
                    {
                        double somaHorizontal = 0;
                        Console.Write("| ");
                        for (int j = 0; j < 3; j++)
                        {
                            double numero = Math.Round((double)random.NextDouble() * 10, 1);
                            Console.Write($"{numero,4} | ");
                            somaHorizontal += numero * GetPeso(j + 1);
                        }
                        double wa = Math.Round(somaHorizontal / GetPesoTotal(), 2);
                        Console.WriteLine($" - {wa}");
                        Console.WriteLine(new string('-', 30));
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido.");
                }
            }
        }
        private static int GetPeso(int posicao)
        {
            switch (posicao)
            {
                case 1:
                    return 2;
                case 2:
                    return 3;
                case 3:
                    return 5;
                default:
                    return 1;
            }
        }
        private static int GetPesoTotal()
        {
            return GetPeso(1) + GetPeso(2) + GetPeso(3);
        }
    }
}