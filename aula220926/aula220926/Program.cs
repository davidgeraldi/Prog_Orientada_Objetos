using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula220926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dicionários: é uma relação funcional entre chaves e valores (itens) de maneira tabular,
            // onde cada chave é única e está associada a um valor específico.
            // diferença do dicionário para a lista é que o dicionário não possui índice, mas sim uma chave única para cada valor.
            // a indexação é genérica, ou seja, pode ser de qualquer tipo de dado, como string, int, double, etc

            Dictionary<int, string> dict = new Dictionary<int, string>();
            // dict.Add(9, "Didier");
            //dict[9] = "Didier";

            //Console.Write(dict[9]);

            Dictionary<string, string> aluno_por_cor_na_lista = new Dictionary<string, string>();

            aluno_por_cor_na_lista["miguel"] = "despintado";
            aluno_por_cor_na_lista["rafael"] = "despintado";
            aluno_por_cor_na_lista["felipe"] = "amarelo";
            aluno_por_cor_na_lista["artur"] = "azul";

            Console.WriteLine("Pré-Remoção:");
            foreach (var relacionamento in aluno_por_cor_na_lista)
            {
                Console.WriteLine($"chave: [{relacionamento.Key}] -> valor: [{relacionamento.Value}]");
            }

            aluno_por_cor_na_lista.Remove("rafael");

            Console.WriteLine("Pós-Remoção:");
            foreach (var relacionamento in aluno_por_cor_na_lista)
            {
                Console.WriteLine($"chave: [{relacionamento.Key}] -> valor: [{relacionamento.Value}]");
            }

            /*
             Exercício 11. Para cada linha da tabela a seguir, construa um dicionário em C# (usando
            Dictionary<string, object>) cujas chaves sejam "Nome", "Grupo", "Período", "Número Atômico" e "Massa Atômica", com os valores correspondentes. Na sequência, cadastre os elementos
            correspondentes:
             */

            Dictionary<string, object> dict_ouro = new Dictionary<string, object>();
            dict_ouro["Nome"] = "Ouro";
            dict_ouro["Grupo"] = 11;
            dict_ouro["Período"] = 6;
            dict_ouro["Número Atômico"] = 79;
            dict_ouro["Massa Atômica"] = 197;

            Dictionary<string, object> dict_prata = new Dictionary<string, object>();
            dict_prata["Nome"] = "Prata";
            dict_prata["Grupo"] = 11;
            dict_prata["Período"] = 5;
            dict_prata["Número Atômico"] = 47;
            dict_prata["Massa Atômica"] = 108;

            Dictionary<string, object> dict_helio = new Dictionary<string, object>();
            dict_helio["Nome"] = "Helio";
            dict_helio["Grupo"] = 18;
            dict_helio["Período"] = 1;
            dict_helio["Número Atômico"] = 2;
            dict_helio["Massa Atômica"] = 4;

            Dictionary<string, object> dict_cloro = new Dictionary<string, object>();
            dict_cloro["Nome"] = "Cloro";
            dict_cloro["Grupo"] = 17;
            dict_cloro["Período"] = 3;
            dict_cloro["Número Atômico"] = 17;
            dict_cloro["Massa Atômica"] = 35;

            Console.Write("\n\n\n");

            Console.Write("------------------------------------------------------------------------\n");
            Console.Write("|  Nome  |  Grupo    |  Período  |  Número Atômico  |  Massa Atômica  |\n");
            Console.Write("------------------------------------------------------------------------\n");
            foreach (var elemento in new List<Dictionary<string, object>> { dict_ouro, dict_prata, dict_helio, dict_cloro })
            {
                Console.WriteLine($"|  {elemento["Nome"],-6}  |  {elemento["Grupo"],-8}  |  {elemento["Período"],-8}  |  {elemento["Número Atômico"],-16}  |  {elemento["Massa Atômica"],-14}  |");
            }

            Console.Write("\n\n\n");
            /*Exercício 12. Modifique o valor da chave "Nome" dos dicionários criados no exercício anterior
              para os símbolos químicos: Ouro → Au, Prata → Ag, Hélio → He, Cloro → Cl.*/

            dict_ouro["Nome"] = "Au";
            dict_prata["Nome"] = "Ag";
            dict_helio["Nome"] = "He";
            dict_cloro["Nome"] = "Cl";

            foreach (var elemento in new List<Dictionary<string, object>> { dict_ouro, dict_prata, dict_helio, dict_cloro })
            {
                Console.WriteLine($"|  {elemento["Nome"],-6}  |  {elemento["Grupo"],-8}  |  {elemento["Período"],-8}  |  {elemento["Número Atômico"],-16}  |  {elemento["Massa Atômica"],-14}  |");
            }

            /*Exercício 13. Crie uma nova chave “Estado físico (CNTP)” nos dicionários e preencha com: Au
            → "Sólido", Ag → "Sólido", He → "Gasoso", Cl → "Gasoso".
            */
            dict_ouro["Estado físico (CNTP)"] = "Sólido";
            dict_prata["Estado físico (CNTP)"] = "Sólido";
            dict_helio["Estado físico (CNTP)"] = "Gasoso";
            dict_cloro["Estado físico (CNTP)"] = "Gasoso";

            Console.Write("\n\n\n");
            Console.Write("|  Nome  |  Grupo    |  Período  |  Número Atômico  |  Massa Atômica  |  Estado físico (CNTP)  |\n");
            foreach (var elemento in new List<Dictionary<string, object>> { dict_ouro, dict_prata, dict_helio, dict_cloro })
            {
                Console.WriteLine($"|  {elemento["Nome"],-6}  |  {elemento["Grupo"],-8}  |  {elemento["Período"],-8}  |  {elemento["Número Atômico"],-16}  |  {elemento["Massa Atômica"],-14}  |  {elemento["Estado físico (CNTP)"],-14}  |");
            }

            /*Exercício 14. Remova a chave "Grupo" dos dicionários criados.*/
            dict_ouro.Remove("Grupo");
            dict_prata.Remove("Grupo");
            dict_helio.Remove("Grupo");
            dict_cloro.Remove("Grupo");

            /*
             Exercício 15. Escreva um programa que crie uma List<Dictionary<string,object» com n
            dicionários (mesmas chaves do exercício 1), onde n é um valor inteiro positivo digitado pelo usuário.
            O preenchimento deve ser feito via Console.ReadLine. Ao final, apresente todos os dicionários
            digitados
            */

            Console.Write("Digite o número de elementos que deseja cadastrar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Dictionary<string, object>> elementos = new List<Dictionary<string, object>>();

            for (int i = 0; i < n; i++)
            {
                Dictionary<string, object> elemento = new Dictionary<string, object>();

                Console.Write("Nome: ");
                elemento["Nome"] = Console.ReadLine();

                Console.Write("Grupo: ");
                elemento["Grupo"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Periodo: ");
                elemento["Período"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Número Atômico: ");
                elemento["Número Atômico"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Massa Atômica: ");
                elemento["Massa Atômica"] = Convert.ToDouble(Console.ReadLine());

                elementos.Add(elemento);
            }

            foreach (var elemento in elementos)
            {
                Console.WriteLine($"|  {elemento["Nome"],-6}  |  {elemento["Grupo"],-8}  |  {elemento["Período"],-8}  |  {elemento["Número Atômico"],-16}  |  {elemento["Massa Atômica"],-14}  |");

            }
        }
    }
}
