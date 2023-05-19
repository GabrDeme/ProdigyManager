using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_FinalizacaoDeSprint
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        DateTime DataCadastro = DateTime.Now;
        private Marca Marca { get; set; }
        private Usuario CadastrarPor { get; set; }


        public Produto()
        {

        }
        public Produto(int codigo, string nomeProduto, float preco)
        {
            this.Codigo = codigo;
            this.NomeProduto = nomeProduto;
            this.Preco = preco;
        }
        List<Produto> listProduto = new List<Produto>();
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Cadastrar(Produto produto)
        {
            Produto produtos = new Produto();
            Console.Write($"Diga o código do produto:");
            produtos.Codigo = int.Parse(Console.ReadLine());
            Console.Write($"Diga o nome do produto:");
            produtos.NomeProduto = Console.ReadLine();
            Console.Write($"Diga o preço do produto:");
            produtos.Preco = float.Parse(Console.ReadLine());

            //this.Codigo = int.Parse("123");
            //this.NomeProduto= "Carlos";
            //this.Preco = int.Parse("123");
            produtos.DataCadastro = DateTime.Now;
            listProduto.Add(produtos);
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Listar()
        {
            // if (listProduto.Count != 0)
            // {
                foreach (Produto p in listProduto)
                {
                    Console.WriteLine(@$"
                    Código: {p.Codigo}
                    Nome: {p.NomeProduto}
                    Preço: {p.Preco:C}
                    {p.DataCadastro}");
                }
            //}
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Deletar(Produto produto, int codigoProduto)
        {
            // this.Codigo = int.Parse("");
            // this.NomeProduto = "";
            // this.Preco = int.Parse("");
            // this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
            
            Produto produtoEncontrado = listProduto.Find(produto => produto.Codigo == codigoProduto);
            listProduto.Remove(produtoEncontrado);

            Console.WriteLine($"Produto deletada com sucesso!");   
        }   
    }
}