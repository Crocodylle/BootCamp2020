using System;


namespace Encapsulamento {
    class program {
        static void Main(string[] args) {

            Produto p = new Produto("TV", 500.00,10);

            p.Nome = "R";
           
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco); 
        }
    }
}