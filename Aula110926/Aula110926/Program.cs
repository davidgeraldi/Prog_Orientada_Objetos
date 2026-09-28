using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula110926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"n[{i}] = {n[i]}");
            }


            foreach (int coordenada in n)
            {
                Console.WriteLine($"coordenada = {coordenada}");
            }


            /*Exercício 5. Gere um int[] vec de tamanho N com valores tais que vec[i] = i^2. 
              Imprima: (a) todos os elementos com foreach; (b) apenas os pares; (c) a soma dos ímpares.
            */

            Console.Write("\n\nTamanho do vetor: ");
            int N = Convert.ToInt16(Console.ReadLine());
            int[] vec = new int[N];
            int somaImpares = 0;

            for (int i = 0; i < vec.Length; i++)
            {
                vec[i] = i * i;
            }

            foreach (int elemento in vec)
            {
                Console.WriteLine($"elemento = {elemento}");
                if ((elemento % 2) != 0)
                {
                    somaImpares += elemento;
                }
            }


            foreach(int elemento in vec)
            {
                if ((elemento % 2 ) == 0)
                {
                    Console.WriteLine($"elemento par = {elemento}");
                }
            }
            
            Console.WriteLine($"Soma dos ímpares = {somaImpares}");


            /*
            Exercício 6. Leia M nomes (string[]). Depois leia um nome alvo e conte, usando foreach,
            quantas ocorrências existem. Mostre também os índices onde aparece.
            */

            Console.Write("\n\n\nQuantidade de nomes: ");
            int M = Convert.ToInt16(Console.ReadLine());

            string[] nomes = new string[M];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Nome {i + 1}: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Write("Pesquisar nome: ");
            string nomeAlvo = Console.ReadLine();
            int ocorrencias = 0;
            foreach (string nome in nomes)
            {
                if (nome == nomeAlvo)
                {
                    ocorrencias++;
                }
            }

            int[] indices = new int[ocorrencias];

            int k = 0;
            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == nomeAlvo)
                {
                    indices[k] = i;
                    k++;
                }
            }
            Console.Write($"{nomeAlvo}: {ocorrencias} ocorrencias nos indices: ");
            foreach (int indice in indices)
            {
                Console.Write($"{indice} ");
            }


            /*
            Exercício 10. Crie uma matriz n×m de inteiros com valores aleatórios. Imprima no formato de
            tabela. Calcule e mostre: (a) soma por linha, (b) soma por coluna, (c) maior elemento e sua posição. 
            */

            Console.Write("\n\n\nlin = ");
            int l = Convert.ToInt16(Console.ReadLine());
            Console.Write("col = ");
            int c = Convert.ToInt16(Console.ReadLine());

            int[,] mat = new int[l, c];
            Random random = new Random();

            for(int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = random.Next(0, l*c);
                }
            }

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < l; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"[{mat[i, j]}]") ;
                }
            }



        }
    }
}
