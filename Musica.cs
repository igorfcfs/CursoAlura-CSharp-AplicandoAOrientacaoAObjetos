using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        /*Atalhos:
        Ctrl + R + R -> renomeia uma propriedade
        cw + tab -> Console.WriteLine();
        prop + TAB -> public int MyProperty { get; set; }
         */
        public string Nome { get; set; }
        public string Artista { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        //Propriedade somente leitura sem lambda
        /* public string DescricaoResumida {
            get
            {
                return $"A música {Nome} pertence à banda {Artista}";
            }
        }*/

        //Propriedade somente leitura com lambda
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome da música: {Nome}");
            Console.WriteLine($"Nome do artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");

            if (Disponivel)
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
