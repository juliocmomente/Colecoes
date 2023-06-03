namespace Colecoes
{
    class Lista
    {
        private List<string> _names { get; set; }

        public Lista()
        {
            _names = new List<string> { "Fulano", "Cicrano", "Beltrano" };
        }
        public void PrintListaNomes()
        {
            System.Console.WriteLine("\nLista:");
            foreach (string name in _names)
            {
                System.Console.WriteLine($"Olá {name.ToUpper()}!");
            }
        }

        public void addNome(string nome)
        {
            _names.Add(nome);
        }

        public void RemoverPrimeiro()
        {
            _names.RemoveAt(0);
        }

        public int EncontrarNome(string nome)
        {
            int posicao = _names.IndexOf(nome);
            return posicao;
        }

        public void OrdenarLista()
        {
            _names.Sort();
        }

        public int getQuantidadeNomes()
        {
            return _names.Count;
        }
    }
}