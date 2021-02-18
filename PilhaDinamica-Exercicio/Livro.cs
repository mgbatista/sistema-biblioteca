using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica_Exercicio
{
    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Isbn { get; set; }
        public Livro Anterior { get; set; }


        public override string ToString()
        {
            return ("\n>>>DADOS DO LIVRO<<<\nTitulo: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + Isbn);
        }
        

        public void ImprimeTitulo(string encontrar)
        {
            if(encontrar == Titulo)
            {
                Console.WriteLine("\n>>>DADOS DO LIVRO<<<\nTitulo: " + Titulo + "\nAutor: " + Autor + "\nISBN: " + Isbn);
            }
            else
            {
                Console.WriteLine("\nLivro NÃO Encontrado!");
            }
        }
    }
}
