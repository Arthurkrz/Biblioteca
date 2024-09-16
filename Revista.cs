using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Revista : ItemBiblioteca
    {
        public Revista(string nome, int ano) : base(nome, ano) { }
        public Revista(string nome, int ano, int atraso) : base(nome, ano, atraso) { }
        public override double CalcularMulta(int atraso)
        {
            return base.CalcularMulta(atraso);
        }
    }
}
