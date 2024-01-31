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
            musica1.Nome = "Roxane";
            musica1.Artista = "The Police";
            musica1.Duracao = 273;
            musica1.Disponivel = true;

            musica1.ExibirFichaTecnica();
            Console.WriteLine(musica1.DescricaoResumida);

            Musica musica2 = new Musica();
            musica2.Nome = "Vertigo";
            musica2.Artista = "U2";
            musica1.Duracao = 367;
            musica1.Disponivel = false;

            musica2.ExibirFichaTecnica();
            Console.WriteLine(musica2.DescricaoResumida);

            Console.WriteLine();

            Album albumDoQueen = new Album();
            albumDoQueen.Nome = "A night at the opera";

            Musica musica3 = new Musica();
            musica3.Nome = "Love of my life";
            musica3.Duracao = 213;

            Musica musica4 = new Musica();
            musica4.Nome = "Bohemian Rhapsody";
            musica4.Duracao = 354;

            albumDoQueen.AdicionarMusica(musica3);
            albumDoQueen.AdicionarMusica(musica4);

            albumDoQueen.ExibirMusicasDoAlbum();
        }
    }
}
