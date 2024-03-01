using System;

namespace Biblioteca
{
    class Coordenadas
    {
        public static void Exercicio()
        {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite as coordenadas de X e Y separadas por vírgula (X,Y) ou digite 'E' para sair: ");
                string input = Console.ReadLine();
                string[] valores = input.Split(',');
                if (valores.Length == 2 && int.TryParse(valores[0], out int valorx) && int.TryParse(valores[1], out int valory))
                {
                    if (valory != 0)
                    {
                        bool controle2 = true;
                        while (controle2)
                        {
                            if ((valorx < 0 ) && (valory > 0))
                            {
                                Console.WriteLine("O ponto está no primeiro quadrante.");
                            }
                            else if ((valorx > 0) && (valory < 0))
                            {
                                Console.WriteLine("O ponto está no quarto quadrante.");
                            }
                            else if ((valorx > 0) && (valory > 0))
                            {
                                Console.WriteLine("O ponto está no segundo quadrante.");
                            }
                            else if ((valorx < 0) && (valory < 0))
                            {
                                Console.WriteLine("O ponto está no terceiro quadrante.");
                            }
                            controle2 = false;
                        }
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Valores inválidos.");
                }
                if (input == "E" || input == "e")
                {
                    controle = false;
                }
            }
        }
    }
}