using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Tarefa
{
    internal class Fila_Livro
    {

        public Livro Cabeca { get; set; }
        public Livro Cauda { get; set; }
        public int nLivros = 0;

        public Fila_Livro()  //construtor. (Control + .) => fazer construtor automatico.
        {
            Cabeca = null;  //fila vazia. os dois nulos.
            Cauda = null;
        }

        public void push(Livro aux)  //insercao pela CAUDA na FILA
        {
            if (vazia())
            {
                Cabeca = aux;  //Sempre insere pela cauda. 
                Cauda = aux;   // 1ª insercao cabeca e cauda apontam para auxiliar. Aux = obj 1.
            }
            else
            {
                Cauda.Proximo = aux; // Faz encadeamento aqui. Obj 1 liga a obj 2 (Proximo)
                Cauda = aux;         // Depois cauda conecta segundo objeto (aux). O obj 2 passa a ser o ultimo da FILA.
            }
            nLivros++;
            Console.WriteLine("Livro cadastrado.");
        }

        public void print()
        {
            if (vazia())
            {
                Console.WriteLine("FILA VAZIA");
            }
            else
            {
                Console.WriteLine("Livros cadastrados.");
                Livro aux = Cabeca;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                    Console.ReadKey();
                } while (aux != null);
            }
        }
        public void print(string busca)
        {
            if (vazia() == true)
            {
                Console.WriteLine("NENHUM LIVRO CADASTRADO");
            }
            else
            {
                Console.WriteLine("BUSCA POR LIVRO");
                Livro aux = Cabeca;
                bool achei = false;
                int n;
                do
                {
                    if (int.TryParse(busca, out n))
                    {
                        if (aux.ISBN == int.Parse(busca))
                        {
                            Console.WriteLine(aux.ToString());
                            achei = true;
                        }
                    }
                    if (string.Equals(aux.Titulo.ToLower(), busca.ToLower()))
                    {
                        Console.WriteLine(aux.ToString());
                        achei = true;
                    }
                    else if (aux.Titulo.ToLower().Contains(busca.ToLower()))
                    {
                        Console.WriteLine(aux.ToString());
                        achei = true;
                    }
                    aux = aux.Proximo;
                } while (aux != null);
                if (!achei)
                {
                    Console.WriteLine("Nenhum livro encontrado");
                }
            }
        }
        public void pop()  //remove pela cabeca
        {
            if (vazia() == true)
            {
                Console.WriteLine("NENHUM LIVRO CADASTRADO");
            }
            else
            {
                Cabeca = Cabeca.Proximo;
                nLivros--;
                Console.WriteLine("Livro removido!");
            }
        }
        public bool vazia()
        {
            if (Cabeca == null)
                return true;
            else
                return false;
        }
        public string numeroLivros()
        {
            if (vazia() == true)
            {
                return "NENHUM LIVRO CADASTRADO";
            }
            else
            {
                return "O numero de livros e: " + nLivros;

            }
        }
    }
}


       