
using Pilha;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

Console.WriteLine("=-=-=-=  Informe o tipo e a cor da roupa  =-=-=-=-=-=-");

PilhaRoupa Armario = new PilhaRoupa();
Roupa roupa;
int op = 0;
int cont = 0;

while (op != 4)
{
    if (cont > 0)
        Console.ReadLine();
        Console.Clear();
    Console.WriteLine(" -=-=-=-=-=-=-=-=-=-=-=-=-=-=  Menu  -=-=-=-=-=-=-=-=-=-=-=-=-=-= \n");
    Console.WriteLine("   [ 1 ] Adicionar roupa    |    [ 2 ] Remover roupa");
    Console.WriteLine("   [ 3 ] Exibir             |    [ 4 ] Sair");
    Console.Write("\nInforme uma opção: ");
    op = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (op)
    {
        case 1:
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            roupa = new Roupa(tipo, cor);
            Armario.Push(roupa);
            break;
        case 2:
            Armario.Pop();
            break;
        case 3:
            Armario.ImprimirPilha();
            break;
        default:
            break;
    }
    cont++;
}
