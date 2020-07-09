using System.Collections.Generic;
using MVC_34.Models;
using MVC_34.Views;

namespace MVC_34.Controllers
{
    public class ProdutoController
    {
        Produto ProdutoModel = new Produto();
        ProdutosViews ProdutoView = new ProdutosViews();

        public void Listar()
        {
            List<Produto> lista = ProdutoModel.Ler();
        }
        public void Buscar(string _preco)
        {
            List<Produto> buscar = ProdutoModel.Ler().FindAll(x => x.Preco == float.Parse(_preco));
            ProdutoView.MostrarNoConsole(buscar);
        }
    }
}