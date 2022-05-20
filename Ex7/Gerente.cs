using System;

namespace Ex7
{
    public class Gerente : Funcionario
    {
        public override double bonificacao() {
            return Salario + 10000;
        }        
    }
}