using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_FinalizacaoDeSprint
{
    public class Marca
    {
        private int Codigo { get; set; }
        private string NomeMarca { get; set; }
        DateTime DataCadastro = DateTime.Now;

        public Marca()
        {

        }
        public Marca(int codigo, string nomeMarca)
        {
            this.Codigo = codigo;
            this.NomeMarca = nomeMarca;
        }
        List<Marca> listMarca = new List<Marca>();
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        
        public void Cadastrar(Marca marca)
        {
            Marca marcas = new Marca();
            Console.Write($"Diga o código da marca:");
            marcas.Codigo = int.Parse(Console.ReadLine());

            // marcas = marcas.Find(.Codigo == codigo);


            Console.Write($"Diga o nome da marca:");
            marcas.NomeMarca = Console.ReadLine();
            marcas.DataCadastro = DateTime.Now;
            listMarca.Add(marcas);

            //this.Codigo = int.Parse("123");
            //this.NomeMarca = "Karlitos";
            
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public void Listar()
        {
            // if (listMarca.Count != 0)
            // {
                foreach (Marca m in listMarca)
                {
                    Console.WriteLine(@$"
                    Código: {m.Codigo}
                    Nome: {m.NomeMarca}
                    {m.DataCadastro}");
                }
            //}
            // else
            // {
            //     Console.WriteLine($"Não há nenhuma marca na lista");
                
            // }
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Deletar(Marca marca, int codigoMarca)
        {
            // Marca deletarm = new Marca();
            // this.Codigo = int.Parse("");
            // this.NomeMarca = "";
            // this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
            // listMarca.Remove(deletarm);
            Marca marcaEncontrado = listMarca.Find(marca => marca.Codigo == codigoMarca);
            listMarca.Remove(marcaEncontrado);
            Console.WriteLine($"Marca deletada com sucesso!");
        }
    }
}