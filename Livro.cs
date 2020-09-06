using System;

namespace Ex_1
{
    public class Livro : Publicacao
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string autor;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private int totalpag;
        public int Totalpag
        {
            get { return totalpag; }
            set { totalpag = value; }
        }
        private int pagAtual;
        public int PagAtual
        {
            get { return pagAtual; }
            set { pagAtual = value; }
        }
        private bool aberto;
        public bool Aberto
        {
            get { return aberto; }
            set { aberto = value; }
        }
        private Pessoa leitor;
        public Pessoa Leitor
        {
            get { return leitor; }
            set { leitor = value; }
        }
        public Livro (string title, string writer, int pages, Pessoa reader)
        {
            this.Titulo = title;
            this.Autor = writer;
            this.PagAtual = 0;
            this.Aberto = false;
            this.Totalpag = pages;
            this.Leitor = reader;
        }
        public String Detalhes()
        {
            return "Livro{" + "\nTítulo=" + this.Titulo + ", \nAutor=" + this.Autor + ", \ntotPaginas=" 
            + this.Totalpag + ", pagAtual=" + this.PagAtual + ", aberto=" + this.Aberto 
            + ", \nLeitor=" + this.Leitor.Nome + ", idade=" + this.Leitor.Idade + ", sexo="
            + this.Leitor.Sexo + "\n}";
        }

        public void Abrir()
        {
            this.Aberto = true;
        }

        public void Fechar()
        {
            this.Aberto = false;
        }

        public void Folhear(int p)
        {
            if(p<=Totalpag)
            {
                this.PagAtual = p;
            }
            else
            {
                this.PagAtual = 0;
                Console.WriteLine("Limite de Páginas Excedido.");
            }
        }
        public void AvancarPag()
        {
            this.PagAtual++;
        }

        public void VoltarPag()
        {
            this.PagAtual--;
        }
    }
}