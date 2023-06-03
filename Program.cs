namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l1 = new Lista();
            l1.PrintListaNomes();
            System.Console.WriteLine("\nAdicionando um nome.");
            System.Console.WriteLine("Digite um nome: ");
            var nome = System.Console.ReadLine();
            if (!string.IsNullOrEmpty(nome))
            {
                l1.addNome(nome);
                l1.PrintListaNomes();

                int posicao = l1.EncontrarNome(nome);
                if (posicao != -1)
                {
                    System.Console.WriteLine($"\nPosicao do nome {nome} é {posicao}");
                }
                else
                {
                    System.Console.WriteLine($"{nome} não encontrado.");
                }
            }
            System.Console.WriteLine($"\nA lista tem {l1.getQuantidadeNomes()} nomes.");

            System.Console.WriteLine("\nOrdenando a lista...");
            l1.OrdenarLista();
            l1.PrintListaNomes();
        }
    }
}

