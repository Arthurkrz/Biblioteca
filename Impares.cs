using System;

namespace Biblioteca
{
    class Impares
    {
        public static void Exercicio3()
        {
            int num;
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite um número inteiro entre 1 e 1000 ou digite 'e' para sair: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out num))
                {
                    for (int i = 1; i <= num; i++){
                        if (i % 2 != 0)
                        {
                            Console.WriteLine("--------------");
                            Console.WriteLine($"{i}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido.");
                }
                if (input == "E" || input == "e")
                {
                    controle = false;
                }
            }
        }
    }
}
