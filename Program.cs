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
        }
    }
}
