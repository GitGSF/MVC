using System;
using System.Collections.Generic;
using MVC_34.Models;

namespace MVC_34.Views
{
    public class ProdutosViews
    {
        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach (Produto item in lista )
            {
                Console.WriteLine($"R${item.Preco} - {item.Nome}");
            }
        }
    }
}