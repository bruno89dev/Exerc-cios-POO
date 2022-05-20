using System;

namespace Ex1
{
    public class Veiculo
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public int acelerar() {
            if (IsLigado == true) {
                Velocidade += 20;
            } else {
                Console.WriteLine("Não há como acelerar um veículo desligado!");
            } return Velocidade;
        }

        public int abastecer(int combustivel) {
             if (LitrosCombustivel + combustivel < 60) {
                 LitrosCombustivel = LitrosCombustivel + combustivel;
                 Console.WriteLine("O tanque foi abastecido com sucesso!");
             } else {
                 Console.WriteLine("A quantidade solicitada para abastecimento supera o limite de 60 litros do tanque, por favor diminua a quantidade e solicite novo abastecimento!");
             } return LitrosCombustivel;
        }

        public int frear() {
            if (IsLigado == true && Velocidade > 0) {
                Velocidade -= 20;
            } else {
                Console.WriteLine("Não há como frear um veículo que já está parado!");
            } return Velocidade;
        }
            
        public string pintar(string corNova) {
            Cor = corNova;
            Console.WriteLine("A cor do seu veículo foi alterada com sucesso!");
            return Cor;
        }

        public bool ligar() {
            if (IsLigado == true) {
                Console.WriteLine ("O veículo já está ligado!");
            } else {
                Console.WriteLine ("O veículo foi ligado!");
            } return IsLigado;
        } 

        public bool desligar() {
            if (Velocidade == 0 && IsLigado == true) {
                Console.WriteLine ("O veículo foi desligado!");
            } else if (Velocidade > 0 && IsLigado == true) {
                Console.WriteLine ("O veículo não pode ser desligado em movimento!");
            } else {
                Console.WriteLine ("O veículo foi desligado!");
            } return IsLigado;
        }
    }
}