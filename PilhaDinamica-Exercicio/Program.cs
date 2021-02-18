using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PilhaDinamicaLivro minhaPilha = new PilhaDinamicaLivro { Topo = null };
            int escolherMenu = 0, cont = 0;

            do
            {
                Console.WriteLine("*** MENU ***");
                Console.WriteLine("\n1- Inserir Livro.");
                Console.WriteLine("2- Remover Livro.");
                Console.WriteLine("3- Imprimir Pilha de Livros.");
                Console.WriteLine("4- Mostrar a quantidade de livros na pilha.");
                Console.WriteLine("5- Buscar um livro na pilha através do título.");
                Console.WriteLine("6- Sair(fechar programa)");

                Console.Write("\nEscolha uma das opções acima:");
                escolherMenu = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (escolherMenu)
                {
                    case 1: //Inserir Livro
                        Console.WriteLine("Informe os dados do livro que deseja cadastrar:");
                        Console.Write("Título: ");
                        string Titulo = Console.ReadLine();
                        Console.Write("Autor: ");
                        string Autor = Console.ReadLine();
                        Console.Write("ISBN: ");
                        int Isbn = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Livro l = new Livro
                        {
                            Titulo = Titulo,
                            Autor = Autor,
                            Isbn = Isbn

                        };
                        minhaPilha.Push(l);
                        cont++;
                        break;

                    case 2: //Remover Livro
                        minhaPilha.Pop();
                        cont--;
                        break;

                    case 3: //Imprimir Pilha de Livros
                        minhaPilha.Imprimir();
                        break;

                    case 4: //Mostrar a quantidade de livros na pilha
                        Console.Write("A quantidade total de livros cadastrados na pilha é de: " + cont);
                        Console.WriteLine("");
                        break;

                    case 5: //Buscar um livro na pilha através do título
                        Console.Write("Informe o título do livro que deseja encontrar: ");
                        string encontrar = Console.ReadLine();
                        minhaPilha.BuscaTitulo(encontrar);
                        break;

                    case 6: //Sair(fechar programa)
                        Console.WriteLine("Pressione qualquer tecla para fechar o programa!");
                        break;

                }
            } while (escolherMenu != 6);

            Console.ReadKey();
        }
        
    }
}
