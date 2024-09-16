using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public int Atraso { get; set; }
        public ItemBiblioteca (string titulo, int ano)
        {
            this.Titulo = titulo;
            this.Ano = ano;
        }
        public ItemBiblioteca(string titulo, int ano, int atraso) : this(titulo, ano)
        {
            this.Atraso = atraso;
        }
        public virtual double CalcularMulta(int atraso)
        {
            return Atraso;
        }

        public virtual void Emprestar(string nome, int ano)
        {

        }
        public virtual void Devolver(string nome, int ano)
        {

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