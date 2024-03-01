    using System;

    namespace Biblioteca
    {
        class Pesoideal
        {
            public static void Exercicio7()
            {
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Digite sua altura em metros (X.XX) e sexo (M ou F) separados por uma barra (alt/M ou F) ou digite 'E' para sair: ");
                string input = Console.ReadLine().ToUpper();
                string[] altsex = input.Split('/');
                if (altsex.Length == 2 && double.TryParse(altsex[0].Replace(',', '.'), out double alt) && (altsex[1] == "M" || altsex[1] == "F"))
                {
                    double pesoidealm = ((alt * 72.7) - 58) / 100;
                    double pesoidealf = ((alt * 62.1) - 44.7) / 100;
                    if (altsex[1] == "M")
                    {
                        Console.WriteLine($"Seu peso ideal é {pesoidealm.ToString("F2")}.");
                        controle = false;
                    }
                    if (altsex[1] == "F")
                    {
                        Console.WriteLine($"Seu peso ideal é {pesoidealf.ToString("F2")}.");
                    }
                    if (input == "E" || input == "e")
                    {
                        controle = false;
                    }
                }
                else
                {
                    Console.WriteLine("Valores incorretos.");
                    
                }
            }
        }
    }
}


// Faça uma função que recebe, por parâmetro, a altura (alt) e o sexo de uma pessoa e retorna o seu peso ideal.
// Para homens, calcular o peso ideal usando a fórmula peso ideal = 72.7 x alt – 58 e, para mulheres, peso ideal = 62.1 x alt – 44.7.