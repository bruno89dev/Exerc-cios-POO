﻿using System;
using System.Collections.Generic;

namespace Ex2
{
    public class Program
    {
        static void Main(string[] args)
        {            
            
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "Fantasia", 300);
            Livro l2 = new Livro("Senhor dos Aneis", 60, 30, "J. R. R. Tolkien", "Fantasia", 500);
            Livro l3 = new Livro("C# POO", 20, 50, "GFT", "Educativo", 500);
            
            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Sony", "Slim", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            l2.CalculaImposto();
            l3.CalculaImposto();

            ps4Usado.CalculaImposto();
            ps4.CalculaImposto();

            americanas.ListaLivros();
            americanas.ListaVideoGames();
            americanas.CalculaPatrimonio();

            // Não consegui adicionar os livros à lista da classe Loja, infelizmente, não entendi qual o erro.
            // Em decorrência da falta dessas informações os métodos ListaLivros, ListaVideoGames e CalculaPatrimonio não estão funcionando.

        }
    }
}