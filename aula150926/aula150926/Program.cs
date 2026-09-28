 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // para manipulação de arquivos

namespace aula150926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string conteudo = "POO melhor matéria";
            //File.WriteAllText("arquivoTeste.txt", conteudo); 
            // não precisar colocar o caminho inteiro, pois ha seu user no meio e pode ser diferente, então o caminho relativo é melhor
            //colocar no executavel do programa
            // se for / usar uma, se for \ usar duas

            //string conteudoLido = File.ReadAllText("C:/POO/arquivoTeste.txt");
            //Console.WriteLine(conteudoLido);

            /*
            Exercício 8. Salve duas matrizes quadradas lidas pelo usuário e cujo número de linhas seja dado
            pelo usuário em A.txt e B.txt. Depois, leia, some, mostre o resultado e salve em C.txt. 
            */
            int n;

            Console.Write("Tamanho matriz 1: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] matA = new int[n, n],
                matB = new int[n, n],
                matC = new int[n, n];


            string A = "";
            string B = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"B[{i},{j}]: ");
                    matB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A += matA[i, j].ToString() + " ";
                    B += matB[i, j].ToString() + " ";
                }
                A += "\n";
                B += "\n";
            }

            File.WriteAllText("A.txt", A);
            File.WriteAllText("B.txt", B);

            string matrizA = File.ReadAllText("A.txt");
            string matrizB = File.ReadAllText("B.txt");

            string[] matriz_A_linhas = matrizA.Split('\n');
            int nmrLinhas = matriz_A_linhas.Length - 1;

            int[,] nova_A = new int[nmrLinhas, nmrLinhas];
            for (int i = 0; i < nmrLinhas; i++)
            {
                string[] conteudo_colunas_A = matriz_A_linhas[i].Split(' ');
                int numero_colunas = conteudo_colunas_A.Length - 1;
                for(int j = 0; j < numero_colunas; j++) {
                    nova_A[i, j] = Convert.ToInt32(conteudo_colunas_A[j]);
                }
            }

            string[] matriz_B_linhas = matrizB.Split('\n');
            nmrLinhas = matriz_B_linhas.Length - 1;

            int[,] nova_B = new int[nmrLinhas, nmrLinhas];
            for (int i = 0; i < nmrLinhas; i++)
            {
                string[] conteudo_colunas_B = matriz_B_linhas[i].Split(' ');
                int numero_colunas = conteudo_colunas_B.Length - 1;
                for (int j = 0; j < numero_colunas; j++)
                {
                    nova_B[i, j] = Convert.ToInt32(conteudo_colunas_B[j]);
                }
            }

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matC[i, j] = nova_A[i, j] + nova_B[i, j];
                }
            }

            string C = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C += matC[i, j].ToString() + " ";
                }
                C += "\n";
            }
            File.WriteAllText("C.txt", C);
        }
    }
}
