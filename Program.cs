using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musica musica1 = new Musica();
            musica1.nome = "Roxane";
            musica1.artista = "The Police";
            musica1.duracao = 273;
            musica1.disponivel = true;

            //Console.WriteLine($"Nome da música {musica1.nome}");
            //Console.WriteLine($"Nome da música {musica1.artista}");

            musica1.ExibirFichaTecnica();

            Musica musica2 = new Musica();
            musica2.nome = "Vertigo";
            musica2.artista = "U2";
            musica1.duracao = 367;
            musica1.disponivel = false;

            //Console.WriteLine($"Nome da música {musica2.nome}");
            //Console.WriteLine($"Nome da música {musica2.artista}");
            musica2.ExibirFichaTecnica();
        }
    }
}
