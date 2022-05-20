using System;

namespace Ex7
{
    public class Vendedor : Funcionario
    {
        public override double bonificacao() {
            return Salario + 3000;
        }
    }
}