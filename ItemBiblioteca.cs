using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class ItemBiblioteca
    {
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Atraso { get; set; } = 0;
        public bool Alugado { get; set; } = false;
        public ItemBiblioteca (string titulo, int ano, string tipo)
        {
            this.Titulo = titulo;
            this.Ano = ano;
            this.Tipo = tipo;
        }
        public ItemBiblioteca(string titulo, int ano, int atraso, string tipo, bool alugado) : this(titulo, ano, tipo)
        {
            this.Alugado = alugado;
            this.Atraso = atraso;
        }
        public virtual double CalcularMulta(int atraso)
        {
            return Atraso;
        }
        public static void Emprestar(ItemBiblioteca[] array, ItemBiblioteca[] array2)
        {
            bool loopEmprestimo = true;
            while (loopEmprestimo)
            {
                Console.Clear();
                Console.WriteLine("Itens a serem emprestados:\n");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null && !array[i].Alugado)
                    {
                        Console.WriteLine($"{i + 1} - '{array[i].Titulo}' de {array[i].Ano};\n");
                    }
                }
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("\nDigite o número do item que deseja emprestar:");
                int emprestimo = int.Parse(Console.ReadLine()) - 1;
                if (emprestimo < array.Length && emprestimo >= 0 && array[emprestimo] != null && !array[emprestimo].Alugado)
                {
                    array2[emprestimo] = array[emprestimo];
                    array[emprestimo].Alugado = true;
                    Console.WriteLine("A devolução do item está atrasada em quantos dias?");
                    array[emprestimo].Atraso = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ocorreu um erro. |");
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine("");
                    loopEmprestimo = false;
                }
                Console.WriteLine("Deseja emprestar outro item ('s'/'n')?");
                string input = Console.ReadLine();
                if (input.ToLower() != "s")
                {
                    Console.Clear();
                    loopEmprestimo = false;
                }
                else
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Não há itens para empréstimo! |");
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("");
                            return;
                        }
                    }
                }
            }
        }
        public static void Devolver(ItemBiblioteca[] array)
        {
            double multaTotal = 0;
            bool loopDevolucao = true;
            while (loopDevolucao)
            {
                Console.Clear();
                Console.WriteLine("Itens a serem devolvidos:\n");
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != null)
                    {
                        Console.WriteLine($"{i + 1} - '{array[i].Titulo}' de {array[i].Ano} com multa " +
                            $"por atraso de R${array[i].CalcularMulta(array[i].Atraso)};\n");
                    }
                }
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("\nDigite o número do item que deseja devolver:");
                int devolucao = int.Parse(Console.ReadLine()) - 1;
                if (devolucao < array.Length && devolucao >= 0 && array[devolucao] != null)
                {
                    double multa = array[devolucao].CalcularMulta(array[devolucao].Atraso);
                    multaTotal += multa;
                    array[devolucao] = null;
                    Console.Clear();
                    Console.WriteLine("Item devolvido com sucesso! |");
                    Console.WriteLine(new string('-', 29));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ocorreu um erro. |");
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine("");
                    loopDevolucao = false;
                }
                Console.WriteLine("Deseja devolver outro item ('s'/'n')?");
                string input = Console.ReadLine();
                if (input.ToLower() != "s")
                {
                    Console.Clear();
                    Console.WriteLine($"\nTotal da multa de atraso de devolução - R${multaTotal}.\n");
                    Console.WriteLine(new string('-', 70));
                    Console.WriteLine("");
                    loopDevolucao = false;
                }
                else
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array[j] == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Não há itens para devolução! |");
                            Console.WriteLine(new string('-', 30));
                            Console.WriteLine("");
                            return;
                        }
                    }
                }
            }
        }
        public static bool ListaCheia(ItemBiblioteca[] array)
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
        public static bool ListaVazia(ItemBiblioteca[] array)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] != null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}