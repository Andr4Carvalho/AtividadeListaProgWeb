using AtividadeLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeLista
{
    public class Venda
    {
        public Venda(int id, DateTime dataVenda, List<Produto> lstaProdutos)
        {
            Id = id;
            DataVenda = dataVenda;
            ListaProdutos = lstaProdutos;
        }

        private int Id;
        private DateTime DataVenda;
        private List<Produto> ListaProdutos;

        public void ImprimirVenda()
        {
            Console.WriteLine($"Venda ID: {Id}");
            Console.WriteLine($"Data: {DataVenda.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Produtos: \n");

            foreach (var item in ListaProdutos)
            {
                Console.WriteLine(item.ImprimirProduto());
            }
        }
    }
}
