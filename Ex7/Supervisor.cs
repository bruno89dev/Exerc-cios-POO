using System;

namespace Ex7
{
    public class Supervisor : Funcionario
    {
        public override double bonificacao() {
            return Salario + 5000;
        }
    }
}