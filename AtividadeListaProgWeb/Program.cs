using AtividadeLista;

List<Produto> produtos = new List<Produto>();
Venda venda = new Venda(1, DateTime.Now, produtos);

for (int i = 0; i < 10; i++)
{
    Produto produto = new Produto(i + 1, i * 5, $"Produto {i * 3}");
    produtos.Add(produto);
}

venda.ImprimirVenda();