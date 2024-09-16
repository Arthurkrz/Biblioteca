using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopInicio = true;
            int tamanho = 0;
            int i = 0;
            while (loopInicio)
            {
                Console.WriteLine("Bem vindo ao sistema de Biblioteca!\n\nInforme a quantidade de produtos que deseja emprestar:");
                int inputInicio = int.Parse(Console.ReadLine());
                if (inputInicio > 0)
                {
                    tamanho = inputInicio;
                    Console.Clear();
                    loopInicio = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Resposta inválida.|");
                    Console.WriteLine(new string('-', 19));
                    Console.WriteLine("");
                }
            }
            ItemBiblioteca[] livros = new ItemBiblioteca[tamanho];
            ItemBiblioteca[] revistas = new ItemBiblioteca[tamanho];
            ItemBiblioteca[] dvds = new ItemBiblioteca[tamanho];
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Bem vindo ao sistema de Biblioteca!\n\nSelecione o dígito da operação a ser realizada:\n\n1 - Cadastrar livro;\n" +
                "2 - Cadastrar revista;\n3 - Cadastrar DVD;\n4 - Realizar empréstimo;\n5 - Consultar empréstimos\n6 - Devolver item;\n7 - Sair.");
                int escolha = int.Parse(Console.ReadLine());
                bool loopInicio2 = true;
                while (loopInicio2)
                {
                    switch (escolha)
                    {
                        case 1:
                            Console.Clear();
                            AdicionarItem(livros, "Livro");
                            loopInicio2 = false;
                            break;
                        case 2:
                            Console.Clear();
                            
                            loopInicio2 = false;
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Digite, linha a linha, o nome e o ano do DVD a ser adicionado:");
                            string nomed = Console.ReadLine();
                            int anod = int.Parse(Console.ReadLine());
                            DVD d = new DVD(nomed, anod);
                            dvds[i] = d;
                            i++;
                            Console.Clear();
                            Console.WriteLine("DVD adicionado com sucesso!|");
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("");
                            loopInicio2 = false;
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine($"Qual item deseja para empréstimo?");
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("Livros:");
                            for (int k = 0; k < i; k++)
                            {
                                if (livros[k] != null)
                                {
                                    Console.WriteLine($"{k + 1} - {livros[k].Titulo} de {livros[k].Ano}");
                                }
                            }
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("Revistas:");
                            for (int k = 0; k < i; k++)
                            {
                                if (revistas[k] != null)
                                {
                                    Console.WriteLine($"{k + 1} - {revistas[k].Titulo} de {revistas[k].Ano}");
                                }
                            }
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("DVDs:");
                            for (int k = 0; k < i; k++)
                            {
                                if (dvds[k] != null)
                                {
                                    Console.WriteLine($"{k + 1} - {dvds[k].Titulo} de {dvds[k].Ano}");
                                }
                            }
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("\nInforme o número do item que deseja emprestar ou digite '0' para sair:");
                            int emprestimo = int.Parse(Console.ReadLine());
                            if (emprestimo > 0 && emprestimo <= i)
                            {
                                Console.Clear();
                                Console.WriteLine("cu!");
                            }
                            else if (emprestimo == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("cu");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("cu");
                            }
                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Obrigado por utilizar nosso sistema de Biblioteca!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Resposta inválida.|");
                            Console.WriteLine(new string('-', 19));
                            Console.WriteLine("");
                            loopInicio2 = false;
                            break;
                    }
                }
                void AdicionarItem(ItemBiblioteca[] array, string tipo)
                {
                    Console.WriteLine($"Digite, linha a linha, o nome e o ano do item '{tipo}' a ser adicionado:");
                    string nome = Console.ReadLine();
                    int ano = int.Parse(Console.ReadLine());
                    ItemBiblioteca item;
                    switch (tipo)
                    {
                        case "Livro":
                            item = new Livro(nome, ano);
                            break;
                        case "Revista":
                            item = new Revista(nome, ano);
                            break;
                        case "DVD":
                            item = new DVD(nome, ano);
                            break;
                        default:
                            return;
                    }
                    if (i < tamanho)
                    {
                        array[i++] = item;
                        Console.WriteLine("Livro adicionado com sucesso!|");
                        Console.WriteLine(new string('-', 30));
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Limite de itens atingido!|");
                        Console.WriteLine(new string('-', 30));
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
//Atividade 2: Sistema de Biblioteca
//Implemente um sistema de gerenciamento de biblioteca, onde exista uma classe base ItemBiblioteca que represente itens gerais como livros, revistas e DVDs.
//Cada item deve ter propriedades como Titulo, Ano e métodos como Emprestar() e Devolver(). Crie subclasses como Livro, Revista, e DVD.
//Além disso, implemente um sistema de controle de multas para itens que foram devolvidos com atraso, onde o valor da multa é calculado com base no tipo de item.
//Cada tipo de item tem uma taxa de multa diferente, por exemplo:
//Livros: multa de R$2 por dia de atraso.
//Revistas: multa de R$1 por dia de atraso.
//DVDs: multa de R$5 por dia de atraso.
//A classe base deve ter um método CalcularMulta(int diasAtraso) para que as subclasses o implementem com suas próprias taxas de multa.
//O sistema deve permitir consultar os itens emprestados e calcular automaticamente o valor total das multas ao devolver o item.

//Console.WriteLine("A devolução do livro está em atraso ('s'/'n')?");
//string escolhaAtrasol = Console.ReadLine();
//int atrasol;
// if (escolhaAtrasol == "s")
//{
//    Console.WriteLine("A devolução está atrasada em quantos dias?");
//    int input = int.Parse(Console.ReadLine());
//    atrasol = input;
//    Livro l = new Livro(nomel, anol, atrasol);
//}
//else
//{
//    Livro l = new Livro(nomel, anol);
//}
//Console.Clear();
//Console.WriteLine("Livro adicionado com sucesso!");
//Console.WriteLine(new string('-', 30));
//Console.WriteLine("");
//loopInicio2 = false;
//\n\n{new string('-', 19)}\nLivros:\n{i} - {livros[i]}\n{new string('-', 19)}\nRevistas:\n{i} - {revistas[i]}\n{new string('-', 19)}" +
//$"\nDVDs:\n{i} - {dvds[i]}\n{new string('-', 19)}");