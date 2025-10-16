
using Pilha;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

Console.WriteLine("=-=-=-=  Informe o tipo e a cor da roupa  =-=-=-=-=-=-");

int op;

while (true)
{
    Console.WriteLine(" -=-=-=-=-=-=-=-=-=-=-=-=-=-=  Menu  -=-=-=-=-=-=-=-=-=-=-=-=-=-= \n");
    Console.WriteLine("   [ 1 ] Adicionar roupa    |    [ 2 ] Remover roupa");
    Console.WriteLine("   [ 3 ] Exibir        |    [ 4 ] Sair");
    Console.Write("\nInforme uma opção: ");
    op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Roupa armario = new Roupa(tipo, cor);
            armario.Tipo = tipo;
            armario.Cor = cor;
            break;
        case 2:
            armario.
            break;
        case 3:
            break;
        case 4:
            break;
    }
}
