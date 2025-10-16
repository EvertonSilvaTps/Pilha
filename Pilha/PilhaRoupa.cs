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

        public PilhaRoupa()
        {
            Topo = null;
        }


        public void Push(Roupa roupa) // Empurrar = inserir
        {
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
                Console.WriteLine("\nPilha vazia");
            else
                Console.WriteLine($"{Topo.ToString()}Foi retirado da pilha");
                Topo = Topo.Proximo;
        }

        public void ImprimirPilha()
        {
            if (Vazia())
                Console.WriteLine("\nPilha vazia");
            else
            {
                Roupa aux = Topo;
                while (aux != null)
                {
                    Console.WriteLine(Topo.ToString());
                    aux = aux.Proximo;
                }
            }

        }
    }
}
