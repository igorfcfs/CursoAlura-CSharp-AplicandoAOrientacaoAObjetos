﻿using System;
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
            Banda queen = new Banda("Queen");

            Album albumDoQueen = new Album("A night at the opera");

            Musica musica1 = new Musica(queen, "Love of my life")
            {
                Duracao = 213,
                Disponivel = true,
            };

            Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
            {
                Duracao = 354,
                Disponivel = false,
            };

            albumDoQueen.AdicionarMusica(musica1);
            albumDoQueen.AdicionarMusica(musica2);
            queen.AdicionarAlbum(albumDoQueen);

            musica1.ExibirFichaTecnica();
            musica2.ExibirFichaTecnica();
            albumDoQueen.ExibirMusicasDoAlbum();
            queen.ExibirDiscografia();



            Console.WriteLine();


            Episodio ep1 = new Episodio(1,"Técnicas de facilitação", 45);
            ep1.AdicionarConvidados("Maria");
            ep1.AdicionarConvidados("Marcelo");
            Console.WriteLine(ep1.Resumo);

            Episodio ep2 = new Episodio(2, "Técnicas de aprendizado", 67);
            ep2.AdicionarConvidados("Fernando");
            ep2.AdicionarConvidados("Marcos");
            ep2.AdicionarConvidados("Flávia");

            Podcast podcast = new Podcast("Podcast Especial", "Daniel");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.ExibirDetalhes();
        }
    }
}
