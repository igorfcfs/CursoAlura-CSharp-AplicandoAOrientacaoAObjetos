using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Podcast
    {
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios { get; set; }

        private List<Episodio> episodios = new List<Episodio>();

        public Podcast(string nome, string host)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
            TotalEpisodios++;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Nome}\n");
            foreach (var episode in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episode.Resumo);
            }
            Console.WriteLine($"Este podcast possui {TotalEpisodios} episódios.");
        }
    }
}
