using System;

namespace Ex2
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }

        public Produto() {
        }
        public Produto(string Nome, double Preco, int Qtd){
            this.Nome = Nome;
            this.Preco = Preco;
            this.Qtd = Qtd;
        }
    }
}