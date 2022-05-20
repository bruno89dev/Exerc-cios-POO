using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiroTeste = new Guerreiro("Baldur, o Bárbaro", 134, 58, 4112, 92, 115, 39);
            guerreiroTeste.lvlUp();
            guerreiroTeste.attack();
            guerreiroTeste.aprenderHabilidade();

            Console.WriteLine($"{guerreiroTeste.Nome} está no level {guerreiroTeste.Level} e tem os seguintes atributos: Vida: {guerreiroTeste.Vida} | Mana: {guerreiroTeste.Mana} | Experiência: {guerreiroTeste.Xp} | Inteligência: {guerreiroTeste.Inteligencia} | Força: {guerreiroTeste.Forca}!");

            Console.WriteLine("__________________________________________________________________________________________________________________________________");

            Mago magoTeste = new Mago("Gandalf, o Branco", 79, 112, 5414, 203, 89, 39);
            magoTeste.lvlUp();
            magoTeste.attack();
            magoTeste.Magia.Add(magoTeste.aprenderMagia());
            foreach (var item in magoTeste.Magia) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"{magoTeste.Nome} está no level {magoTeste.Level} e tem os seguintes atributos: Vida: {magoTeste.Vida} | Mana: {magoTeste.Mana} | Experiência: {magoTeste.Xp} | Inteligência: {magoTeste.Inteligencia} | Força: {magoTeste.Forca}");

        }
    }
}
