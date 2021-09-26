using System;
using System.Collections.Generic;
using System.Text;

namespace Salarios
{
    public class gerenciarsalario 
    {
        private double _totalsalario;
        public void RegistrarSalario(Funcionario funcionario)

        {
            _totalsalario += funcionario.GetSalario();

        }

        public double GetTotalSalario()
        {
            return _totalsalario;
        }
    }

}
