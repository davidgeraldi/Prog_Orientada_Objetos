using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula131026
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Pessoa professor = new Pessoa();

                Pessoa monitor = new Pessoa();

                professor.Nome = "Rodrigo Colnago Contreras";
                professor.Idade = 34;
                professor.Email = "contreras@unifesp.br";
                professor.AlturaCM = 190;
                professor.Peso = 98;

                double imc = professor.RetornaIMC();

                Console.WriteLine($"imc do obj professor: {imc}");

                monitor.Nome = "Leonardo Castro Carvalho";
                monitor.Idade = 22;
                monitor.Email = "castro.carvalho@unifesp.br";
                monitor.Peso = 62;
                monitor.AlturaCM = 170;

                imc = monitor.RetornaIMC();

                Console.WriteLine($"imc do obj monitor: {imc}");
        }
    }
}
