using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica_Exercicio
{
    class PilhaDinamicaLivro
    {
        public Livro Topo { get; set; }
        

        public void Push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;

            

            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.WriteLine("");
            return;
        }


        private bool Vazia()
        {
            if (Topo == null)
                return true;
            return false;
        }


        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Remover! Pilha de Livros Vazia!");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Livro Removido do cadastro com sucesso!");
                Console.WriteLine("");
            }
        }


        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Pilha de Livros Vazia!");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os livros cadastrados na pilha são:");
                Console.WriteLine("");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<<");
                Console.WriteLine("");
            }
        }


        public void BuscaTitulo(string encontrar)
        {
            Livro aux = Topo;
            do
            {
                aux.ImprimeTitulo(encontrar);
                aux = aux.Anterior;
                Console.WriteLine("");
            } while (aux != null);


        }
    }
}
