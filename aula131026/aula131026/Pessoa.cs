using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula131026
{
    internal class Pessoa
    {
        public int AlturaCM;
        public int Idade;
        public double Peso;
        public string Nome;
        public string CPF;
        public string Email;

        public double RetornaIMC()
        {
            double h = AlturaCM / 100.0;
            return Peso / (h * h);
        }
    }
}
