using System;

namespace Secao4_PrimeirosExs {
    class Program {
        static void Main(string[] args) {

            Ex1();
            Ex2();

            static void Ex1() {
                Pessoa x, y;
                x = new Pessoa();
                y = new Pessoa();

                Console.WriteLine("Favor fornecer o nome e idade da primeira pessoa: ");
                x.nome = Console.ReadLine();
                x.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Favor fornecer o nome e idade da segunda pessoa: ");
                y.nome = Console.ReadLine();
                y.idade = int.Parse(Console.ReadLine());

                if (x.idade > y.idade) {
                    Console.WriteLine($"A idade de {x.nome} é maior.");
                }
                else if (x.idade < y.idade) {
                    Console.WriteLine($"A idade de {y.nome} é maior.");
                }
                else {
                    Console.WriteLine($"{y.nome} e {x.nome} têm a mesma idade.");
                }
            }

            static void Ex2() {

                Funcionario x, y;

                x = new Funcionario();
                y = new Funcionario();

                Console.WriteLine("Favor fornecer nome e salário do primeiro funcionário: ");
                x.nome = Console.ReadLine();
                x.salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Favor fornecer nome e salário do segundo funcionário: ");
                y.nome = Console.ReadLine();
                y.salario = double.Parse(Console.ReadLine());

                double media = (x.salario + y.salario) / 2;

                Console.WriteLine($"A média salarial é {media}.");

            }


        }
    }
}
