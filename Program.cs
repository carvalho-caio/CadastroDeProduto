using System;
using CadastroDeProduto.Classes;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace CadastroDeProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objeto que controla o fluxo do programa;
            Tela T = new Tela();

            //variaveis de cadastro de produto
            string nome = "";
            int id = 0;
            double preco = 0.0;

            //Variaveis referente ao menu de opcoes
            int valorDigitadoMenu = 0;

            while (T.StatusDoPrograma)
            {
                try
                {
                    //inicio do programa;
                    T.MenuOpcoes();

                    Console.WriteLine("");
                    Console.Write("Opcao: ");
                    valorDigitadoMenu = int.Parse(Console.ReadLine());


                    //Input menu de opcoes
                    if (valorDigitadoMenu == 1)
                    {
                        int Teste = 0;
                        Console.Clear();

                        Console.Write("Digite o nome do produto: ");
                        nome = Console.ReadLine();

                        Console.Write("Digite o id do produto: ");
                        id = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preco do produto: ");
                        preco = double.Parse(Console.ReadLine());

                        T.Lista.Add(T.CadastrarProduto(nome, id, preco));
                        Console.Clear();
                    }
                    else if (valorDigitadoMenu == 2)
                    {
                        Console.Write("Digite o ID do produto a ser deletado: ");
                        id = int.Parse(Console.ReadLine());

                        T.DeletarProduto(T.Lista, id);
                    }
                    else if (valorDigitadoMenu == 3)
                    {
                        Console.Clear();
                        T.ConsultarProdutos(T.Lista);
                    }
                    else if (valorDigitadoMenu == 4)
                    {
                        T.FinalizarPrograma();
                    }
                    else
                    {
                        throw new ExcecaoCustomizada("Numero invalido!");
                    }
                }
                catch (ExcecaoCustomizada e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Parametro invalido.");
                }
            }
        }
    }
}