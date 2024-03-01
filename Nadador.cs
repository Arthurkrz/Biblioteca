using System;

namespace Biblioteca
{
	class Nadador
	{
		public static void Exercicio8()
		{
			bool controle = true;
            while (controle)
            {
				Console.WriteLine("Digite a idade do nadador ou digite 'E' para sair: ");
				string input = Console.ReadLine();
				if (int.TryParse(input, out int idade) && idade > 5)
                {
					string categoria;
					if (idade <= 7)
                    {
						categoria = "Infantil A";
						Console.WriteLine($"O nadador de {idade} anos é da categoria {categoria}");
                    }
					else if (idade >= 8 && idade <= 10) 
					{
						categoria = "Infantil B";
						Console.WriteLine($"O nadador de {idade} anos é da categoria {categoria}");
					}
					else if (idade >= 11 && idade <= 13)
					{
						categoria = "Juvenil A";
						Console.WriteLine($"O nadador de {idade} anos é da categoria {categoria}");
					}
					else if (idade >= 14 && idade <= 17)
					{
						categoria = "Juvenil B";
						Console.WriteLine($"O nadador de {idade} anos é da categoria {categoria}");
					}
					else if (idade >= 18)
					{
						categoria = "Adulto";
						Console.WriteLine($"O nadador de {idade} anos é da categoria {categoria}");

					}
					if (input == "E" || input == "e")
					{
						controle = false;
					}
				}
                else
                {
					Console.WriteLine("Valor inválido. Favor digitar um número inteiro maior que 5.");
                }
            }
		}
	}
}