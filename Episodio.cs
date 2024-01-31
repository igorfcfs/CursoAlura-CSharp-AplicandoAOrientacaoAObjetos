using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Episodio
    {
        public int Duracao { get; }
        public int Ordem { get; }
        public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
        public string Titulo { get; }

        private List<string> convidados = new List<string>();

        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }

        public void AdicionarConvidados(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}
