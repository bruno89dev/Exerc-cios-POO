using System;

namespace Ex7
{
    public abstract class Funcionario
    { 
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public virtual double bonificacao() {
            return Salario;
        }
    }
}