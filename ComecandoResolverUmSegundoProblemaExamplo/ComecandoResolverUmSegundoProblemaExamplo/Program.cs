using System;
using System.Globalization;

namespace ComecandoResolverUmSegundoProblemaExamplo {
    class Program {
        static void Main(string[] args) {


            Produto p = new Produto();

            Console.WriteLine(" entre com os dados do produto");
            Console.Write(" Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o numero de produto a ser adicionado no estoque ? ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);


            Console.WriteLine("Digite o numero de produto a ser removido no estoque ? ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
           
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
