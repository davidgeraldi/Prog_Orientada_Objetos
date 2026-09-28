using System;
using System.Collections.Generic; //enumerate, dicionario, lista
using System.Linq; //
using System.Text;
using System.Threading.Tasks; // 

namespace aula08092026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!\n\n"); //WriteLine para várias linhas

            // Console.ReadLine(); // retorna uma linha digitada pelo usuario no tipo string

            /* Exercício 1. Imprima no console seu nome, curso e semestre usando Console.WriteLine. Em
            seguida, leia do teclado(com Console.ReadLine) a sua linguagem favorita e mostre: "Linguagem
            favorita: < ...> ". */

            Console.WriteLine("Nome:David Geraldi\nCurso: Eng. da Computação\nSemestre: 4\n\n");

            Console.Write("Linguagem favorita: ");
            string lingFav = Console.ReadLine(); // salva a resposta do usuário na variável lingFav
            Console.WriteLine("\nSua linguagem favorita é: " + lingFav);
            Console.WriteLine($"\nSua linguagem favorita é: {lingFav}");

            /*Exercício 2. Leia dois inteiros do teclado e exiba soma, diferença, produto e quociente (divisão
            inteira e divisão real formatada com 2 casas).*/

            Console.Write("\nDigite n: ");
            int n = Convert.ToInt16(Console.ReadLine());

            Console.Write("\nDigite m: ");
            int m = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"\nSoma: {n + m}\nDiferença: {n - m}\nProduto: {n * m}");
            if (m != 0)
            {
                Console.WriteLine($"Quociente: {(1.0*n) / m:F2}"); 
                //multiplica por 1.0 para forçar a conversão para double e evitar divisão inteira
            }
            else throw new Exception("Já viu divisão por 0?");

            /*Exercício 3. Implemente um menu de console (loop) com as opções 1-Calcular IMC, 2-Converter
            Celsius→Fahrenheit, 0-Sair. Cada opção deve ler dados, calcular e imprimir o resultado.*/

            int op;
            do
            {
                Console.WriteLine("\n\n---------------- Escolha a Operação ----------------\n\n");
                Console.WriteLine("[1] Calcular IMC\n[2] Converter Celcius->Fahrenheint\n[0] Sair");
                op = Convert.ToInt16(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Digite seu peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite sua altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        double imc = peso / (altura * altura);
                        Console.WriteLine($"Seu IMC é: {imc:F2}");
                        break;

                    case 2:
                        Console.Write("Digite a temperatura em Celsius: ");
                        double temp = Convert.ToDouble(Console.ReadLine());
                        double fahrenheit = 1.8 * temp + 32;
                        Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2}");
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (op != 0);
            



        }
    }
}
