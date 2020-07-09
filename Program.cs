using System;
using MVC_34.Controllers;

namespace MVC_34
{
    class Program
    {
        static void Main(string[] args)
        {

            ProdutoController teste = new ProdutoController();

            teste.Buscar("599,98");
        }
    }
}
