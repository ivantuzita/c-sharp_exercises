using System;

namespace ex4For {
    class Program {
        static void Main(string[] args) {
           // Console.WriteLine("Escreva um número inteiro:");
           // Console.WriteLine(Ex1());

           // Console.WriteLine("Escreva um número inteiro:");
           // Console.WriteLine(Ex2());

            //Console.WriteLine("Escreva quantos casos terão:");
            //Console.WriteLine(Ex3());

           // Console.WriteLine("Escreva quantos casos terão:");
            //Console.WriteLine(Ex4());

            //Console.WriteLine("Escreva o número para fatorial: ");
           //Console.WriteLine(Ex5());

            //Console.WriteLine("Escreva o número para ver os divisores: ");
            //Console.WriteLine(Ex6());

            Console.WriteLine("Escreva o número para ver os divisores: ");
            Console.WriteLine(Ex7());
        }

        static string Ex1() {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

            return "Fim do código.";
        }

        static string Ex2() {

            int n = int.Parse(Console.ReadLine());
            int contIn = 0, contOut = 0;

            for (int i = 1; i <= n; i++) {
                
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20) {
                    contIn++;
                    // Console.WriteLine($"{num} in");
                }
                else {
                    contOut++;
                    // Console.WriteLine($"{num} out");
                }

            }

            return $"{contIn} in \n {contOut} out";
        }


        static string Ex3() {

            /* Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
            de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
            conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
            peso 5. */

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Escreva o primeiro número:");
                double um = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o segundo número:");
                double dois = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o terceiro número:");
                double tres = double.Parse(Console.ReadLine());

                double resultado = (um * 2 + dois * 3 + tres * 5) / (2 + 3 + 5);

                Console.WriteLine($"{resultado.ToString("n1")}");
            }

            return "Fim do código.";

        }

        static string Ex4() {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Escreva o primeiro número:");
                int um = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o segundo número:");
                int dois = int.Parse(Console.ReadLine());

                try {
                    double resultado = um / dois;
                    Console.WriteLine($"{resultado.ToString("n1")}");
                }
                catch {
                    Console.WriteLine($"Divisão impossível.");
                }
            }

            return "Fim do código.";

        }

        static string Ex5() {

            int n = int.Parse(Console.ReadLine());
            int res = 1;

            for (int i = n; i != 0; i--) {
                res *= i;
            }

            Console.WriteLine(res);
            return "Fim do código.";

        }

        static string Ex6() {

            int n = int.Parse(Console.ReadLine());

            for (int i = n; i != 0; i--) {

                if (n % i != 0) {
                    ;
                }
                else {
                    Console.WriteLine(i);
                }
            }

            return "Fim do código.";

        }

        static string Ex7() {

            int n = int.Parse(Console.ReadLine()); //numero de vezes q vai rodar
            string coiso; // concatenação da string

            for (int i = 1; i <= n; i++) {

                coiso = $"{i} {i*i} {i*i*i}";

                Console.WriteLine(coiso);
            }

            return "Fim do código";
        }

    }
}
