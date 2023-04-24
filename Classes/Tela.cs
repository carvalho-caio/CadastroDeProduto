using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CadastroDeProduto.Classes;
using System.Security.Cryptography.X509Certificates;

namespace CadastroDeProduto.Classes
{
    internal class Tela
    {
        //variaveis
        public bool StatusDoPrograma { get; private set; }

        public List<Produto> Lista = new List<Produto>();

        //construtor
        public Tela()
        {
            StatusDoPrograma = true;
        }

        //funcoes

        public Produto CadastrarProduto(string nome, int id, double preco)
        {
            Console.Clear();
            return new Produto(nome, id, preco);
        }

        public void DeletarProduto(List<Produto> lista, int id)
        {
            if (lista.Count == 0)
            {
                Console.Clear();
                throw new ExcecaoCustomizada("Lista Vazia");
            }
            
            for(int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Id == id)
                {
                    lista.Remove(lista[i]);
                    return;
                }
            }

            Console.Clear();
            throw new ExcecaoCustomizada("ID nao encontrado.");
        }

        public void ConsultarProdutos(List<Produto> lista)
        {
            if (lista.Count == 0)
            {
                throw new ExcecaoCustomizada("Lista esta vazia.");
            }

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Display();
            }
        }

        public void FinalizarPrograma()
        {
            StatusDoPrograma = false;
        }

        //Funcoes de display
        public void MenuOpcoes()
        {
            Console.WriteLine("");
            Console.WriteLine("Sistema de cadastro Supermercado X");
            Console.WriteLine("");

            Console.WriteLine("Opcoes:");
            Console.WriteLine("Digite 1 para Cadastrar novo produto.");
            Console.WriteLine("Digite 2 para Deletar um produto.");
            Console.WriteLine("Digite 3 para Consultar os produtos cadastrados.");
            Console.WriteLine("Digite 4 para finalizra o programa.");
        }

    }
}
