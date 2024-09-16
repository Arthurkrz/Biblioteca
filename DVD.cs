using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class DVD : ItemBiblioteca
    {
        public DVD(string nome, int ano) : base(nome, ano) { }
        public DVD(string nome, int ano, int atraso) : base(nome, ano, atraso) { }
        public override double CalcularMulta(int atraso)
        {
            return base.CalcularMulta(atraso) * 5.0;
        }
    }
}
