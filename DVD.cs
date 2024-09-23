using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class DVD : ItemBiblioteca
    {
        public DVD(string nome, int ano, string tipo) : base(nome, ano, tipo) { }
        public DVD(string nome, int ano, int atraso, string tipo, bool alugado) : base(nome, ano, atraso, tipo, alugado) { }
        public override double CalcularMulta(int atraso)
        {
            return base.CalcularMulta(atraso) * 5.0;
        }
    }
}
