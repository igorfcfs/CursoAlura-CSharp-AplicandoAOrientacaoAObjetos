using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        public bool disponivel;

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome da música: {nome}");
            Console.WriteLine($"Nome do artista: {artista}");
            Console.WriteLine($"Duração: {duracao}");

            if (disponivel)
            {
                Console.WriteLine("Disponível no plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }
    }
}
