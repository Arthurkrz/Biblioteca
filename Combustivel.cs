using System;

namespace Biblioteca
{
    class Combustivel
    {
        public static void Exercicio2()
        {
            bool controle = true;
            int contAlcool = 0;
            int contGasolina = 0;
            int contDiesel = 0;
            while (controle)
            {
                Console.WriteLine("Selecione os produtos de 1 a 4: \n 1 - Álcool; \n 2 - Gasolina; \n 3 - Diesel; \n 4 - Fim.");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int opcao) && opcao >= 0 && opcao <= 4)
                {
                    switch (opcao)
                    {
                        case 1:
                            contAlcool++;
                            break;
                        case 2:
                            contGasolina++;
                            break;
                        case 3:
                            contDiesel++;
                            break;
                        case 4:
                            Console.WriteLine($"Muito Obrigado!\n Álcool - {contAlcool}; \n Gasolina - {contGasolina}; \n Diesel - {contDiesel}.");
                            controle = false;
                            break;
                        default:
                            Console.WriteLine("Numeração inválida");
                            return;
                    }
                }
                else
                {
                    Console.WriteLine("Código de produto inválido.");
                }
            }
        }
    }
}
