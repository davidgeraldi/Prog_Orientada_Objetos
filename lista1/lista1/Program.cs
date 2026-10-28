using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Nome: David Geraldi\nCurso: Eng. Computação\nSemestre: 4°");
            Console.Write("Linguagem favorita: ");
            string ling = Console.ReadLine();
            Console.WriteLine($"Linguagem favorita: {ling}"); 
            */

            /*Console.Write("Numero 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Soma: {a + b}\nDiferença: {a - b}\nProduto: {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"Quociente: {a / b}");
            }
            else
                Console.WriteLine("Não é possível dividir por zero.");
            */

            int op;
            do
            {
                Console.Write("Menu\n[1] - IMC\n[2] - Celcius -> Farhenheit\n[0] - Sair\n\n");
                Console.Write("Operação: ");
                op = Convert.ToInt16(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.Write("Peso: ");
                        double peso = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Altura: )");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        double IMC = peso / (altura * altura);
                        Console.WriteLine($"IMC: {IMC}");
                        break;

                    case 2:
                        Console.Write("Temperatura em Celcius: ");
                        double celcius = Convert.ToDouble(Console.ReadLine());
                        double F = (celcius * 1.8) + 32;
                        Console.Write($"Conversão de {celcius}°C para Farhenheit: {F}°F");
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            } while (op != 0);

        }
    }
}
