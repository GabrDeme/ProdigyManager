using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_FinalizacaoDeSprint
{
    public class Usuario
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        DateTime DataCadastro = DateTime.Now;

        public Usuario()
        {
            //Cadastrar();
        }
        public Usuario(int codigo, string nome, string email, string senha)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Cadastrar(Usuario usuario)
        {
            // this.Nome = "Jorge";
            // this.Email = "1";
            // this.Senha = "1";
            // this.DataCadastro = DateTime.Now;
            //usuario.Add(usuario);
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void Deletar(Usuario usuario)
        {
        //     this.Nome = "";
        //     this.Email = "";
        //     this.Senha = "";
        //     this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        //     //usuarios.Remove(usuario);
        }
    }
}