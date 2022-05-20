using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            pessoa1.Idade = 15;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Leandro";
            pessoa2.Idade = 21;

            Pessoa pessoa3 = new Pessoa();
            pessoa3.Nome = "Paulo";
            pessoa3.Idade = 17;

            Pessoa pessoa4 = new Pessoa();
            pessoa4.Nome = "Jessica";
            pessoa4.Idade = 18;

            List<Pessoa> listaPessoa = new List<Pessoa>();
            listaPessoa.Add(pessoa1);
            listaPessoa.Add(pessoa2);
            listaPessoa.Add(pessoa3);
            listaPessoa.Add(pessoa4);

            listaPessoa = listaPessoa.Where(x=>x.Idade >= 18).ToList();

            foreach (var item in listaPessoa) {
                
                if (item.Nome == "Jessica") {

                    Console.WriteLine($"{item.Nome} se encontra na lista, sua idade é de {item.Idade} anos.");

                }
            }
        }
    }
}