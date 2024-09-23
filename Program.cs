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
            ItemBiblioteca[] itens = new ItemBiblioteca[tamanho];
            ItemBiblioteca[] itensEmprestados = new ItemBiblioteca[tamanho];
            bool controle = true;
            while (controle)
            {
                Console.WriteLine("Bem vindo ao sistema de Biblioteca!\n\nSelecione o dígito da operação a ser realizada:\n\n1 - Cadastrar livro;\n" +
                "2 - Cadastrar revista;\n3 - Cadastrar DVD;\n4 - Realizar empréstimo;\n5 - Consultar empréstimos\n6 - Devolver item;\n7 - Sair.");
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
                        bool loopEmprestimo = true;
                        while (loopEmprestimo)
                        {
                            Console.Clear();
                            Console.WriteLine("Itens a serem emprestados:");
                            for (int k = 0; k < itens.Length; k++)
                            {
                                if (itens[k] != null && itens[k].Alugado)
                                {
                                    Console.WriteLine($"{k + 1} - {itens[k].Titulo} de {itens[k].Ano};");
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Todos os itens foram emprestados!|");
                                    Console.WriteLine(new string('-', 19));
                                    loopEmprestimo = false;
                                }
                                Console.WriteLine("");
                                Console.WriteLine(new string('-', 30));
                                Console.WriteLine("\nInforme o número do item que deseja emprestar:");
                                int emprestimo = int.Parse(Console.ReadLine()) - 1;
                                if (emprestimo < itens.Length && emprestimo > 0 && itens[emprestimo] != null && !itens[emprestimo].Alugado)
                                {
                                    itensEmprestados[i++] = itens[emprestimo];
                                    itens[emprestimo].Alugado = true;
                                    Console.WriteLine("A devolução do item está atrasada em quantos dias?");
                                    int atraso = int.Parse(Console.ReadLine());
                                    itens[emprestimo].Atraso = atraso;
                                    Console.Clear();
                                    Console.WriteLine("Deseja emprestar outro item ('s'/'n')?");
                                    string input = Console.ReadLine();
                                    if (input == "s")
                                    {
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        loopEmprestimo = false;
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Ocorreu um erro.|");
                                    Console.WriteLine(new string('-', 19));
                                    loopEmprestimo = false;
                                }
                            }
                        }
                        break;
                    case 5:
                        Console.Clear();
                        double multaTotal = 0;
                        for (int l = 0; l < itensEmprestados.Length; l++)
                        {
                            if (itensEmprestados[l] != null)
                            {
                                double multa = itensEmprestados[l].CalcularMulta(itensEmprestados[l].Atraso);
                                Console.WriteLine($"{itensEmprestados[l].Tipo} intitulado '{itensEmprestados[l].Titulo} de {itensEmprestados[l].Ano} com multa " +
                                    $"por atraso de R${multa};\n");
                                multaTotal += multa;
                            }
                            Console.WriteLine($"Multa total por atraso de R${multaTotal}.");
                        }
                        break;
                   case 6:
                        if (ListaVazia(itensEmprestados))
                        {
                            Console.WriteLine("Não há devoluções a serem feitas!");
                            break;
                        }
                        bool loopDevolucao = true;
                        while (loopDevolucao)
                        {
                            for (int l = 0; l < itensEmprestados.Length; l++)
                            {
                                if (itensEmprestados[l] != null)
                                {
                                    Console.WriteLine($"{l + 1} - '{itensEmprestados[l].Titulo}' de {itensEmprestados[l].Ano} com multa " +
                                        $"por atraso de R${itensEmprestados[l].CalcularMulta(itensEmprestados[l].Atraso)};\n");
                                }
                                else
                                {
                                    Console.WriteLine("Não há devoluções a serem feitas!");
                                    loopDevolucao = false;
                                }
                            }
                            Console.WriteLine("Digite o índice do item que deseja devolver:");
                            int devolucao = int.Parse(Console.ReadLine()) - 1;
                            if (devolucao < itensEmprestados.Length && devolucao > 0 && itensEmprestados[devolucao] != null)
                            {
                                double multa = itensEmprestados[devolucao].CalcularMulta(itensEmprestados[devolucao].Atraso);
                                itensEmprestados[devolucao] = null;
                                Console.WriteLine($"Total da multa de atraso de devolução - R${itensEmprestados[devolucao].CalcularMulta(itensEmprestados[devolucao].Atraso)}.\n");
                                Console.WriteLine("Deseja devolver outro item ('s'/'n')?");
                                string input = Console.ReadLine();
                                if (input == "s")
                                {
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.Clear();
                                    loopDevolucao = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ocorreu um erro.|");
                                loopDevolucao = false;
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
                        Console.WriteLine("Resposta inválida.|");
                        Console.WriteLine(new string('-', 19));
                        Console.WriteLine("");
                        break;
                    }
                static void AdicionarItem(ItemBiblioteca[] array, string tipo)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == null)
                        {
                            Console.WriteLine($"Digite, linha a linha, o nome e o ano do item '{tipo}' a ser adicionado:");
                            string nome = Console.ReadLine();
                            int ano = int.Parse(Console.ReadLine());
                            ItemBiblioteca item;
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
                            array[j] = item;
                            Console.WriteLine($"{tipo} adicionado com sucesso!|");
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("");
                            return;
                        }
                    }
                    Console.WriteLine("Limite de itens atingido!|");
                }

                bool ListaCheia(ItemBiblioteca[] array)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == null)
                        {
                            return false;
                        }
                    }
                    return true;
                }
                bool ListaVazia(ItemBiblioteca[] array)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == null)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
        }
    }
}