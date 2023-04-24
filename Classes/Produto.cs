using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeProduto.Classes
{
    internal class Produto
    {
        //Variaveis
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public double Preco { get; private set; }


        //construtor
        public Produto(string nome, int id, double preco)
        {
            Nome = nome;
            Id = id;
            Preco = preco;
        }

        //funcoes
        public void Display()
        {
            Console.WriteLine("");

            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Preco: {Math.Round(Preco, 2)}");
        }
    }
}
