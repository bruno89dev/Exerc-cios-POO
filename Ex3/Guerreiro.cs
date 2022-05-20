using System;
using System.Collections.Generic;

namespace Ex3
{
    public class Guerreiro : Personagem
    {
            public Guerreiro(string Nome, int Vida, int Mana, float Xp, int Inteligencia, int Forca, int Level) {
            this.Nome = Nome;
            this.Vida = Vida;
            this.Mana = Mana;
            this.Xp = Xp;
            this.Inteligencia = Inteligencia;
            this.Forca = Forca;
            this.Level = Level;
        }

        public override void lvlUp() {
            this.Level += 1;
            this.Vida += 8;
            this.Mana += 5;
            this.Xp += 10;
            this.Inteligencia += 4;
            this.Forca += 12;
            Console.WriteLine("LEVEL UP!");
        }
        
        public int attack() {            
            Random r = new Random();
            int rInt = r.Next(0, 300);
            int attack = ((Inteligencia * Level) + rInt);
            Console.WriteLine($"{this.Nome} atacou causando {attack} ao seu oponente!");
            return attack;
        }

        public void aprenderHabilidade() {
            if (Level % 10 == 0) {
                if (Level < 11) {
                    Console.WriteLine($"{this.Nome} aprendeu a técnica INVESTIDA!");
                } else if (Level < 21) {
                    Console.WriteLine($"{this.Nome} aprendeu a técnica QUEBRA ESCUDO!");
                } else if (Level < 31) {
                    Console.WriteLine($"{this.Nome} aprendeu a técnica BLITZ!");
                } else if (Level < 41) {
                    Console.WriteLine($"{this.Nome} aprendeu a técnica ATAQUE ENFURECIDO!");
                } else if (Level == 50) {
                    Console.WriteLine($"{this.Nome} aprendeu a técnica suprema: PUNHO DE HADES!");
                }
            }
        }
    }
}