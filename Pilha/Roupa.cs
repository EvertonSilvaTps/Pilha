using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pilha
{
    public class Roupa
    {
        public string Tipo;
        public string Cor;
        public Roupa Proximo;

        public Roupa(string tipo, string cor)
        {
            this.Tipo = tipo;
            this.Cor = cor;
            Proximo = null;
        }

        public override string ToString()
        {
            return $"Tipo: {this.Tipo}\nCor: {this.Cor}\n";
        }

    }
}
