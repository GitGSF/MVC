using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVC_34.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/produto.csv";

        public Produto (int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produto()
        {
            string pasta = PATH.Split('/')[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }


        //Ler info
        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var linha in linhas)
            {
                string[] dados = linha.Split(';');

                Produto prod = new Produto();
                prod.Codigo = Int32.Parse(Separar(dados[0]));
                prod.Nome = Separar(dados[1]);
                prod.Preco = float.Parse(Separar(dados[2]));

                produtos.Add(prod);
            }

            produtos = produtos.OrderBy(z => z.Nome).ToList();
            return produtos;
        }
        public string Separar(string dado)
        {
            return dado.Split('=')[1];
        }
    }
}