using System.Globalization;
namespace ExemploProperties
{
    class Produto
    {
        
        //Atributos PRIVADOS

        private string _nome;
        private double _preco;
        private int _quantidade;

        // ------------------------------------
        
        // Construtor com 3 argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // -----------------------------------
        
        //PROPERTIES ↓ (Métodos GET E SET dentro da classe | No método SET o valor a ser alterado se modifica para VALUE
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        // --------------------------------
        
        // ENCAPSULAMENTO de Variáveis privadas
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        public double ValorTotalEmEstoque
        {
            get { return _preco * _quantidade; }
        }

        // ------------------------------------

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        //Método ToString para retornar na classe principal
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque.ToString("F2", CultureInfo.InvariantCulture);
        }

        //-----------------------------------
    }
}