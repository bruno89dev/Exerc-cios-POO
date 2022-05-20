using System;
using System.Collections.Generic;

namespace Ex3
{
    public class Mago : Personagem 
    {

        public List<String> Magia { get; set; }

        public Mago(string Nome, int Vida, int Mana, float Xp, int Inteligencia, int Forca, int Level) {
            this.Nome = Nome;
            this.Vida = Vida;
            this.Mana = Mana;
            this.Xp = Xp;
            this.Inteligencia = Inteligencia;
            this.Forca = Forca;
            this.Level = Level;
            this.Magia = new List<string>();
        }

        public override void lvlUp() {
            this.Level += 1;
            this.Vida += 5;
            this.Mana += 8;
            this.Xp += 10;
            this.Inteligencia += 12;
            this.Forca += 4;
            Console.WriteLine("LEVEL UP!");
        }

        public int attack() {            
            Random r = new Random();
            int rInt = r.Next(0, 300);
            int attack = ((Inteligencia * Level) + rInt);
            Console.WriteLine($"{this.Nome} atacou causando {attack} ao seu oponente!");
            return attack;
        }

        public string aprenderMagia() {
            if (Level % 10 == 0) {
                if (Level < 11) {
                    return $"{this.Nome} aprendeu a técnica BOLA DE FOGO!";
                } else if (Level < 21) {
                    return $"{this.Nome} aprendeu a técnica TERREMOTO!";
                } else if (Level < 31) {
                    return $"{this.Nome} aprendeu a técnica NEVASCA!";
                } else if (Level < 41) {
                    return $"{this.Nome} aprendeu a técnica TEMPESTADE NEBULOSA!";
                } else if (Level == 50) {
                    return $"{this.Nome} aprendeu a técnica suprema: ERUPÇÃO DE MAGMA!";
                }   return "";
            } else {
                return "";
            }
        }
    }
}