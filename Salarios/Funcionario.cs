using System;
using System.Collections.Generic;
using System.Text;

namespace Salarios
{
    public class Funcionario : Terceiros
    {

        public string nome { get; set; }
        public int cargaHoraria { get; set; }
        public double valorHora { get; set; }
        public Funcionario(string a, int b, double c, string d, int e)
        {
            nome = a;
            cargaHoraria = b;
            valorHora = c;
            empresa = d;
            taxa = e;
        }

        public double GetSalario()
        {

            return valorHora * cargaHoraria + taxa;
        }
    }
}
