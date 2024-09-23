using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Livro : ItemBiblioteca
    {
        public Livro(string nome, int ano, string tipo) : base(nome, ano, tipo) { }
        public Livro(string nome, int ano, int atraso, string tipo, bool alugado) : base(nome, ano, atraso, tipo, alugado) { }
        public override double CalcularMulta(int atraso)
        {
            return base.CalcularMulta(atraso) * 2.0;
        }
    }
}
