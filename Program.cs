using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopInicio = true;
            int tamanho = 0;
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
                    Console.WriteLine("Resposta inválida. |");
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine("");
                }
            }
            ItemBiblioteca[] itens = new ItemBiblioteca[tamanho];
            ItemBiblioteca[] itensEmprestados = new ItemBiblioteca[tamanho];
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Bem vindo ao sistema de Biblioteca!\n\nSelecione o dígito da operação a ser realizada:\n\n1 - Cadastrar livro;\n" +
                "2 - Cadastrar revista;\n3 - Cadastrar DVD;\n4 - Realizar empréstimo;\n5 - Consultar empréstimos;\n6 - Devolver item;\n7 - Sair.");
                int escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Console.Clear();
                        AdicionarItem(itens, "Livro");
                        break;
                    case 2:
                        Console.Clear();
                        AdicionarItem(itens, "Revista");
                        break;
                    case 3:
                        Console.Clear();
                        AdicionarItem(itens, "DVD");
                        break;
                    case 4:
                        if (ItemBiblioteca.ListaVazia(itens))
                        {
                            Console.Clear();
                            Console.WriteLine("Não existem itens a serem emprestados! |");
                            Console.WriteLine(new string('-', 40));
                            Console.WriteLine("");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            ItemBiblioteca.Emprestar(itens, itensEmprestados);
                        }
                        break;
                    case 5:
                        Console.Clear();
                        double multaTotal = 0;
                        if (ItemBiblioteca.ListaVazia(itensEmprestados))
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum item foi emprestado! |");
                            Console.WriteLine(new string('-', 29));
                            Console.WriteLine("");
                            break;
                        }
                        for (int l = 0; l < itensEmprestados.Length; l++)
                        {
                            if (itensEmprestados[l] != null)
                            {
                                double multa = itensEmprestados[l].CalcularMulta(itensEmprestados[l].Atraso);
                                Console.WriteLine($"{itensEmprestados[l].Tipo} intitulado '{itensEmprestados[l].Titulo}' de {itensEmprestados[l].Ano} com multa " +
                                    $"por atraso de R${multa};\n");
                                multaTotal += multa;
                            }
                        }
                        Console.WriteLine($"Multa total por atraso de R${multaTotal}.");
                        Console.WriteLine(new string('-', 70));
                        Console.WriteLine("");
                        break;
                    case 6:
                        if (ItemBiblioteca.ListaVazia(itensEmprestados))
                        {
                            Console.Clear();
                            Console.WriteLine("Não há devoluções a serem feitas! |");
                            Console.WriteLine(new string('-', 35));
                            Console.WriteLine("");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            bool loopEmprestimo = true;
                            while (loopEmprestimo)
                            {
                                ItemBiblioteca.Devolver(itensEmprestados);
                            }
                        }
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Obrigado por utilizar nosso sistema de Biblioteca!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Resposta inválida. |");
                        Console.WriteLine(new string('-', 20));
                        Console.WriteLine("");
                        break;
                        void AdicionarItem(ItemBiblioteca[] array, string tipo)
                        {
                            if (ItemBiblioteca.ListaCheia(itens))
                            {
                                Console.Clear();
                                Console.WriteLine("Limite de itens atingido! |");
                                Console.WriteLine(new string('-', 27));
                                Console.WriteLine("");
                            }
                            else
                            {
                                for (int j = 0; j < array.Length; j++)
                                {
                                    if (array[j] == null)
                                    {
                                        Console.WriteLine($"Digite, linha a linha, o nome e o ano do item '{tipo}' a ser adicionado:");
                                        string nome = Console.ReadLine();
                                        int ano = int.Parse(Console.ReadLine());
                                        ItemBiblioteca item;
                                        if (nome != null && ano > 0)
                                        {
                                            switch (tipo)
                                            {
                                                case "Livro":
                                                    item = new Livro(nome, ano, tipo);
                                                    break;
                                                case "Revista":
                                                    item = new Revista(nome, ano, tipo);
                                                    break;
                                                case "DVD":
                                                    item = new DVD(nome, ano, tipo);
                                                    break;
                                                default:
                                                    return;
                                            }
                                            Console.Clear();
                                            array[j] = item;
                                            Console.WriteLine($"{tipo} adicionado com sucesso!");
                                            Console.WriteLine(new string('-', 30));
                                            Console.WriteLine("");
                                            return;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Ocorreu um erro. |");
                                            Console.WriteLine(new string('-', 18));
                                            Console.WriteLine("");
                                        }
                                    }
                                }
                            }
                        }
                }
            }
        }
    }
}