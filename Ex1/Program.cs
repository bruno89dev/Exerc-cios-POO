using System;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculoTeste = new Veiculo();
            veiculoTeste.Marca = "Mercedes";
            veiculoTeste.Placa = "AAA-1A23";
            veiculoTeste.Cor = "preta";
            veiculoTeste.Km = 80674;
            veiculoTeste.IsLigado = false;
            veiculoTeste.LitrosCombustivel = 17;
            veiculoTeste.Velocidade = 0;
            veiculoTeste.Preco = 350000;

            veiculoTeste.ligar();
            veiculoTeste.LitrosCombustivel = veiculoTeste.abastecer(40);
            veiculoTeste.pintar("azul metálico");
            
            Console.WriteLine($"O veículo da marca {veiculoTeste.Marca} é da cor {veiculoTeste.Cor}, tem {veiculoTeste.Km} Km rodados, o tanque tem atualmente {veiculoTeste.LitrosCombustivel} litros de combustível, custa R${veiculoTeste.Preco} e sua velocidade atual é de {veiculoTeste.Velocidade} Km/h");

            Console.WriteLine("_______________________________________________________________________________________________________________________________");

            Veiculo veiculoTeste2 = new Veiculo();
            veiculoTeste2.Marca = "BMW";
            veiculoTeste2.Placa = "BMW-1A23";
            veiculoTeste2.Cor = "branca";
            veiculoTeste2.Km = 23119;
            veiculoTeste2.IsLigado = true;
            veiculoTeste2.LitrosCombustivel = 45;
            veiculoTeste2.Velocidade = 100;
            veiculoTeste2.Preco = 435000;

            veiculoTeste2.acelerar();
            veiculoTeste2.acelerar();
            veiculoTeste2.frear();
            veiculoTeste2.LitrosCombustivel = veiculoTeste2.abastecer(20);
            veiculoTeste2.desligar();
            
            Console.WriteLine($"O veículo da marca {veiculoTeste2.Marca} é da cor {veiculoTeste2.Cor}, tem {veiculoTeste2.Km} Km rodados, o tanque tem atualmente {veiculoTeste2.LitrosCombustivel} litros de combustível, custa R${veiculoTeste2.Preco} e sua velocidade atual é de {veiculoTeste2.Velocidade} Km/h");
        }
    }
}
