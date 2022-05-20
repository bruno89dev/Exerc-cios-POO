using System;
using System.Collections.Generic;

namespace Ex2
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        List<Livro> livros = new List<Livro>();
        List<VideoGame> videoGames = new List<VideoGame>();

        public Loja() {
            
        }

        public Loja(string Nome, string Cnpj, List<Livro> livros, List<VideoGame> games){

        }
      
        public void ListaLivros() {
            if (livros.Count == 0) {
                Console.WriteLine("Não existem livros");
            } else {
                Console.WriteLine("Teste");
            }
        }

        public void ListaVideoGames() {
            foreach (var item in videoGames) {
                if (videoGames.Count == 0) {
                    Console.WriteLine("A loja não tem video-games no seu estoque.");
                } else {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        public double CalculaPatrimonio() {
            
            return 1;
        }
    }
}