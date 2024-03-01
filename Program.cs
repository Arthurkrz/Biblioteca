using System;

namespace Biblioteca
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Digite a opção de exercício de 1 a 7: \n 1 - Coordenadas\n 2 - Combustível\n 3 - Ímpares\n 4 - Inteiros\n 5 - Média Ponderada\n 6 - Valor Carro\n 7 - Peso Ideal\n 8 - Idade do Nadador\n 9 - Notas com 'A' ou 'P'");
                if (int.TryParse(Console.ReadLine(), out int numeroex) && numeroex > 0 && numeroex <= 9)
                {
                    switch (numeroex)
                    {
                        case 1:
                            Coordenadas.Exercicio();
                            break;
                        case 2:
                            Combustivel.Exercicio2();
                            break;
                        case 3:
                            Impares.Exercicio3();
                            break;
                        case 4:
                            Inteiros.Exercicio4();
                            break;
                        case 5:
                            Tresvalores.Exercicio5();
                            break;
                        case 6:
                            Valorcarro.Exercicio6();
                            break;
                        case 7:
                            Pesoideal.Exercicio7();
                            break;
                        case 8:
                            Nadador.Exercicio8();
                            break;
                        case 9:
                            Notasap.Exercicio9();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Favor digitar um número");
                }
                Console.Write("Deseja retornar ao catálogo inicial (S ou N)?: ");
                string inputretorno = Console.ReadLine().ToLower();
                if (inputretorno.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    Environment.Exit(0);
                }
                else if (!inputretorno.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Opção inválida.");
                    Environment.Exit(0);
                }

            }

        }
    }
}
