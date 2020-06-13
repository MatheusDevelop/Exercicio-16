using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();
            sapato.Nome = "Versace";

            Produto chinelo = new Produto(45);
            System.Console.WriteLine(chinelo.Codigo);

            Produto camisa = new Produto(34, "Nike", "Preto", 294);
            System.Console.WriteLine(camisa.Codigo);
            System.Console.WriteLine(camisa.Nome);
            System.Console.WriteLine(camisa.Descricao);
            System.Console.WriteLine(camisa.Estoque);

        }
    }
}
