using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_FinalizacaoDeSprint
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login()
        {
            Usuario user = new Usuario();

            Logar(user);

            if (Logado == true)
            {
                GerarMenu();
            }
        }
        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Já possui uma conta?");
            string respostaCadastro = Console.ReadLine().ToLower();
            if (respostaCadastro == "sim")
            {
                Console.Write($"Insira seu Email: ");
                string email = Console.ReadLine();
                Console.Write($"Insira sua senha: ");
                string senha = Console.ReadLine();

                //if (email == usuario.Email && senha == usuario.Senha)
                if (email == "1" && senha == "1")
                {
                    this.Logado = true;
                    Console.WriteLine($"Login efetuado com sucesso!");
                }
                else
                {
                    this.Logado = false;
                    Console.WriteLine($"Houve algum erro ao logar!");
                }
            }
            else if (respostaCadastro == "não")
            {
                usuario.Cadastrar(usuario);
            }
            else
            {
                Console.WriteLine($"Resposta inválida!");
            }
        }
        public void Deslogar()
        {
            this.Logado = true;
            Console.WriteLine($"Usuário deslogado");
        }
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;

            do
            {
                Console.WriteLine(@$"
            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------
            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca

            [0] - Sair
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar(produto);
                        marca.Cadastrar(marca);
                        break;
                    case "2":
                        produto.Listar();
                        marca.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());

                        produto.Deletar(produto, codigoProduto);
                        break;
                    case "4":
                        marca.Cadastrar(marca);
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o código a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        marca.Deletar(marca, codigoMarca);
                        break;
                    case "0":
                        Console.WriteLine($"App encerrado!");
                        break;
                    default:
                        Console.WriteLine($"Opção inválida!");
                        break;
                }
            } while (opcao != "0");
        }
    }
}