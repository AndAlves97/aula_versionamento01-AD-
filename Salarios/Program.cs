using System;

namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario("Carlos", 200, 40,"Funcionario interno", 0);
            funcionario2 = new Funcionario("Roberta", 200, 40, "Terceira 123", 100);


            Console.WriteLine(funcionario1.nome + " é um funcionario interno");
            Console.WriteLine("Possui carga horario de :" + funcionario1.cargaHoraria);
            Console.WriteLine("Com valor de hora de : R$"+ funcionario1.valorHora);
            Console.WriteLine("Com o total de salario de:" + funcionario1.GetSalario());
            Console.WriteLine("");
            Console.WriteLine("---");
            Console.WriteLine("");
            Console.WriteLine(funcionario2.nome + " é um funcionario terceiro");
            Console.WriteLine("Possui carga horario de :" + funcionario2.cargaHoraria);
            Console.WriteLine("Com valor de hora de : R$" + funcionario2.valorHora);
            Console.WriteLine("Com o total de salario de:" + funcionario2.GetSalario());

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
