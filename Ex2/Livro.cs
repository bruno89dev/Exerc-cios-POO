using System;
using System.Collections.Generic;

namespace Ex2
{
    public class Livro : Produto, IImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        public List<Livro> livros { get; set; }

        public Livro() {

        }

        public Livro(string Nome, double Preco, int Qtd, string Autor, string Tema, int QtdPag){
            this.Nome = Nome;
            this.Preco = Preco;
            this.Qtd = Qtd;
            this.Autor = Autor;
            this.Tema = Tema;
            this.QtdPag = QtdPag;
        }

        public double CalculaImposto() {
            if (Tema == "Educativo") {
                Console.WriteLine($"Livro educativo não tem imposto: {this.Nome}");
                return 0;
            } else {
                double imposto = this.Preco * 0.10;
                Console.WriteLine($"R${imposto} de impostos sobre o livro {this.Nome}");
                return imposto;
            }
        }
    }
}