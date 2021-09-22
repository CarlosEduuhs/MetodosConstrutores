using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criacao de Classe - Atributos e Métodos
            //Produto prod1 = new Produto();
            //prod1.SetNome("Monitor");
            //prod1.preco = 630.80;
            //prod1.estoque = 80;
            //Console.WriteLine(prod1.preco * prod1.estoque);
            //Produto prod2 = new Produto();
            //prod2.SetNome("Mouse");
            //prod2.preco = 28.99;
            //prod2.estoque = 150;
            //Console.WriteLine(prod2.ValorEstoque().ToString("C"));

            //Produto prod3 = new Produto("Teclado", 21.35, 200);
            //Console.WriteLine(prod3.ValorEstoque().ToString("C"));

            //Produto prod4 = new Produto("Cabo HDMI");
            //prod4.preco = 7.50;
            //prod4.estoque = 50;
            //Console.WriteLine(prod4.ValorEstoque().ToString("C"));


            //Metodos Construtores; sobreposição de metodos; encapsulamento



            Produto produto = new Produto("Monitor", 650.50, 50);
            Console.WriteLine(produto.GetNome());
            Console.WriteLine(produto.SetNome("Monitor 21.5"));
            produto.Preco = 550.90;
            produto.SomaEstoque(200);
            Console.WriteLine(produto.Estoque);



            Console.ReadKey();

        }
    }
}
