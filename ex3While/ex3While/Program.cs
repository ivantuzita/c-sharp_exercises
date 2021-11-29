using System;

namespace ex3While {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um senha: ");
            Console.WriteLine(Ex1());

            Console.WriteLine("Digite o X: ");
            Console.WriteLine(Ex2());

            Console.WriteLine("Digite o código: ");
            Console.WriteLine(Ex3());

        }

        static string Ex1() {

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Você errou, seu desgraçado burro!");
                Console.WriteLine("Digite a senha novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            return "Senha correta!";
        }

        static string Ex2() {

            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a coordenada Y: ");
            int Y = int.Parse(Console.ReadLine());

            while (X != 0 || Y != 0) {

                if (X > 0 && Y > 0) { //primeiro quadrante
                    Console.WriteLine("Objeto está no primeiro quadrante.");
                }
                else if (X < 0 && Y > 0) {
                    Console.WriteLine("Objeto está no segundo quadrante.");
                }
                else if (X < 0 && Y < 0) {
                    Console.WriteLine("Objeto está no terceiro quadrante.");
                }
                else if (X > 0 && Y < 0) {
                    Console.WriteLine("Objeto está no quarto quadrante.");
                }

                Console.WriteLine("Escreva a coordenada X novamente: ");
                X = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva a coordenada Y novamente: ");
                Y = int.Parse(Console.ReadLine());
            }

            return "Coordenada inválida.";
        }

        static string Ex3() {

            int cod = int.Parse(Console.ReadLine());

            while (cod != 4) {

                switch (cod) {
                    case 1:
                        Console.WriteLine("1. Álcool");
                        break;
                    case 2:
                        Console.WriteLine("2. Gasolina");
                        break;
                    case 3:
                        Console.WriteLine("3. Diesel");
                        break;
                    default:
                        Console.WriteLine("Código inválido!");
                        break;
                }
                cod = int.Parse(Console.ReadLine());

            }
            return "MUITO OBRIGADO.";
        }
    }
}
