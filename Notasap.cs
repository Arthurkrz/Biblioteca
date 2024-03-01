using System;

namespace Biblioteca
{
    class Notasap
    {
        public static void Exercicio9()
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite as 3 notas (decimais ou não) seguidas das letras 'A' ou 'P' separadas por '/' (X/Y/Z/A ou P) ou digite 'E' para sair: ");
                string input = Console.ReadLine().ToLower();
                string[] inputnotas = input.Split('/');
                if (input.ToLower() == "e")
                {
                    controle = false;
                }
                if (inputnotas.Length == 4 && double.TryParse(inputnotas[0], out double nota1) && double.TryParse(inputnotas[1], out double nota2) && double.TryParse(inputnotas[2], out double nota3) && (inputnotas[3] == "a" || inputnotas[3] == "p") && input.ToLower() != "e")
                {
                    if (inputnotas[3] == "a")
                    {
                        double mediaaritmetica = (nota1 + nota2 + nota3) / 3;
                        Console.WriteLine(new string('-', 25));
                        Console.WriteLine($"| {nota1} | {nota2} | {nota3} | {mediaaritmetica}");
                    }
                    else if (inputnotas[3] == "p")
                    {
                        double mediaponderada = Math.Round((nota1 * GetPeso(1) + nota2 * GetPeso(2) + nota3 * GetPeso(3)) / GetPesoTotal(), 2);
                        Console.WriteLine(new string('-', 22));
                        Console.WriteLine($"| {nota1} | {nota2} | {nota3} | {mediaponderada}");
                        Console.WriteLine(new string('-', 22));
                    }
                }
                else if (input.ToLower() != "e")
                {
                    Console.WriteLine("Valores inválidos.");
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
