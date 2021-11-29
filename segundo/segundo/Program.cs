using System;

namespace segundo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] infos = Console.ReadLine().Split(' ');

            string lName = infos[0];
            int idade = int.Parse(infos[1]);
            double altura = double.Parse(infos[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(lName);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}
