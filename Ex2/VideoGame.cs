using System;

namespace Ex2
{
    public class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }

        public VideoGame() {
        }
        public VideoGame(string Nome, double Preco, int Qtd, string Marca, string Modelo, bool IsUsado){
            this.Nome = Nome;
            this.Preco = Preco;
            this.Qtd = Qtd;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.IsUsado = IsUsado;
        }

        public double CalculaImposto() {
            if (IsUsado == true) {
                double imposto = this.Preco * 0.25;
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo} usado, R$ {imposto}");
                return imposto;
            } else {
                double imposto = this.Preco * 0.45;
                Console.WriteLine($"Imposto {this.Nome} {this.Modelo}, R$ {imposto}");
                return imposto;
            }
        }
    }
}