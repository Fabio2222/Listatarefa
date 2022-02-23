using System;

namespace Lista_Tarefa
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            void WaitClear()
            {
                Console.ReadKey();
                Console.Clear();
            }
        
            int opcao;
            Fila_Livro minha_fila = new Fila_Livro();
            
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1-Cadastrar livro");
                Console.WriteLine("2-Remover primeiro livro cadastrado");
                Console.WriteLine("3-Mostrar livros");
                Console.WriteLine("4-Mostrar numero de livros cadastrados");
                Console.WriteLine("5-Buscar livro");
                Console.WriteLine("0-sair");
                if (int.TryParse(Console.ReadLine(), out int canParse))
                {
                    opcao = canParse;
                }
                else
                {
                    opcao = -1;
                }
                switch (opcao)
                {
                    case 1:
                        int ISBN, anoPublicacao;
                        string titulo;
                        Console.Clear();
                        Console.WriteLine("CADASTRO");
                        do
                        {
                            Console.WriteLine("ISBN: ");
                            if (int.TryParse(Console.ReadLine(), out int canParse2))
                            {
                                ISBN = canParse2;
                                break;
                            }
                            Console.WriteLine("Valor invalido.\n Digite de novo");
                        } while (true);
                        Console.WriteLine("Titulo: ");
                        titulo = Console.ReadLine();
                        do
                        {
                            Console.WriteLine("Ano de publicacao: ");
                            if (int.TryParse(Console.ReadLine(), out int canParse3))
                            {
                                anoPublicacao = canParse3;
                                break;
                            }
                        } while (true);
                        minha_fila.push(new Livro(ISBN, titulo, anoPublicacao));
                        WaitClear();
                        break;

                    case 2:
                        Console.Clear();
                        minha_fila.pop();
                        WaitClear();
                        break;

                    case 3:
                        Console.Clear();
                        minha_fila.print();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine(minha_fila.numeroLivros());
                        WaitClear();
                        break;

                    case 5:
                        string busca;
                        Console.Clear();
                        if (minha_fila.vazia())
                        {
                            Console.WriteLine("NENHUM LIVRO CADASTRADO");
                            WaitClear();
                        }
                        else
                        {
                            Console.WriteLine("Digite o ISBN ou Titulo do livro: ");
                            busca = Console.ReadLine();
                            minha_fila.print(busca);
                            WaitClear();
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Inválida!");
                        WaitClear();
                        break;
                }
            } while (opcao != 0) ;
        }
    }
}

                













