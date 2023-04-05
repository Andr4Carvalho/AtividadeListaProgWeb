namespace AtividadeLista
{
    public class Produto
    {
        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }

        private int Id;
        private decimal Valor;
        private string Descricao;

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public decimal getValor()
        {
            return Valor;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }
        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public string ImprimirProduto()
        {
            return ($"ID: {Id}\nValor: {Valor}\nDescricao: {Descricao}");
        }
    }
}