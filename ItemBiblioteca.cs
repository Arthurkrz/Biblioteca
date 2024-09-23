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
        public virtual void Emprestar(int emprestimo, int i)
        {
            ItemBiblioteca[] emprestados = new ItemBiblioteca[i];
        }
        public virtual void Devolver(string nome, int ano)
        {

        }
    }
}