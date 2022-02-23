using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Tarefa
{
    internal class Livro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Proximo { get; set; }

        public Livro(int iSBN, string titulo, int anoPublicacao)  // Control + . (faz construtor automatico, alterar o Proximo pata nulo.)
        {
            ISBN = iSBN;
            Titulo = titulo;
            AnoPublicacao = anoPublicacao;
            Proximo = null;
        }

        public override string ToString()
        {
            return "------INFORMAÇÃO DO LIVRO-----\n" + "ISBN:\n" + ISBN + "\nTitulo:\n" + Titulo + "\nPublicacao:\n" + AnoPublicacao;
        }
    }
}
