using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Gerente gerentePaulo = new Gerente();
            gerentePaulo.Nome = "Paulo";
            gerentePaulo.Idade = 52;
            gerentePaulo.Salario = 22000;
            double bonificacaoGerentePaulo = gerentePaulo.bonificacao();

            Supervisor supervisorMaria = new Supervisor();
            supervisorMaria.Nome = "Maria";
            supervisorMaria.Idade = 44;
            supervisorMaria.Salario = 14000;
            double bonificacaoSupervisorMaria = supervisorMaria.bonificacao();

            Vendedor vendedorJose = new Vendedor();
            vendedorJose.Nome = "José";
            vendedorJose.Idade = 37;
            vendedorJose.Salario = 5000;
            double bonificacaoVendedorJose = vendedorJose.bonificacao();

            Console.WriteLine($"Gerente: {gerentePaulo.Nome} | Idade: {gerentePaulo.Idade} | Salário: R$ {gerentePaulo.Salario} | Bonificação: R$ {bonificacaoGerentePaulo}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Supervisor: {supervisorMaria.Nome} | Idade: {supervisorMaria.Idade} | Salário: R$ {supervisorMaria.Salario} | Bonificação: R$ {bonificacaoSupervisorMaria}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Vendedor: {vendedorJose.Nome} | Idade: {vendedorJose.Idade} | Salário: R$ {vendedorJose.Salario} | Bonificação: R$ {bonificacaoVendedorJose}");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}