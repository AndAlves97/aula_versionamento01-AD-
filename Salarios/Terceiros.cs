using System;
using System.Collections.Generic;
using System.Text;

namespace Salarios
{
    public class Terceiros
    {
        public int taxa;

        public string empresa;

        public Terceiros() { }
        public Terceiros(string empresa, int taxa)
        {
            _empresaOrigem = empresa;
            _taxaServiço = taxa;
        }
        public string _empresaOrigem
        {
            get { return _empresaOrigem; }
            set { 
                if(value.Length<3)
                {
                    Console.WriteLine("Erro: nome invalido");
                }
                else
                {
                    _empresaOrigem = value;
                }
                    
                }
        }

        public int _taxaServiço
        {
            get { return _taxaServiço; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Erro: taxa invalido");
                }
                else
                {
                    _taxaServiço = value;
                }

            }
        }


    }
}
