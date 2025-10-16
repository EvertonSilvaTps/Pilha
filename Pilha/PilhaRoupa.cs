using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class PilhaRoupa
    {
        public Roupa Topo;  // head = cabeça = inicio da pilha

        public void Push(Roupa roupa) // Empurrar = inserir
        {
            roupa.Proximo = null;
            if (Vazia())
                Topo = roupa;
            else
                Topo.Proximo = roupa;
                Topo = roupa;
        }

        public bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }

        public void Pop()  // remover
        {
            if (Vazia())
                Console.WriteLine("Pilha vazia");
            else
                Topo = Topo.Proximo;
        }

        public void ImprimirPilha()
        {
            if (Vazia())
                Console.WriteLine("Fila Vazia");
            else
            {
                Roupa aux = Topo;
                while (aux != null)
                {
                    Console.WriteLine(aux.Tipo);
                    Console.WriteLine(aux.Cor);
                    aux = aux.Proximo;
                }
            }

        }




    }
}
