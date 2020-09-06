using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] p = new Pessoa[2];
            Livro[] l = new Livro[3];

            p[0] = new Pessoa("Pedro", 22,"M");
            p[1] = new Pessoa("Maria", 25, "F");

            l[0] = new Livro("Aprendendo C#", "José da Silva", 300, p[0]);
            l[1] = new Livro("POO Para Iniciantes", "Pedro Paulo", 500, p[1]);
            l[2] = new Livro("Java Avançado", "Maria Candido", 800, p[0]);

            l[0].Abrir();
            l[0].Folhear(400);
            Console.WriteLine(l[0].Detalhes());
            Console.WriteLine(l[1].Detalhes());
        }
    }
}
