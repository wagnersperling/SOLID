using System;

namespace LSP_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funci1 = new Gerente("Carlos", "Cargo");
            Console.WriteLine(funci1.GetType());

            Funcionario funci2 = new Vendedor("Wagner", "Cargo");
            Console.WriteLine(funci2.GetType());

            Console.WriteLine("Salário do Gerente");
            var salario1 = funci1.CalculaSalario(5000);
            Console.WriteLine(salario1);

            Console.WriteLine("Salário do Vendedor");
            var salario2 = funci2.CalculaSalario(3000);
            Console.WriteLine(salario2);
            Console.ReadKey();
        }
    }
}
