using System;

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Video[] v = new Video[3];
            v[0] = new Video("Aula 1 de POO");
            v[1] = new Video("Aula 12 de PHP");
            v[2] = new Video("Aula 10 de HTML5");

            Console.WriteLine(v[0].Status());
            Gafanhoto[] g = new Gafanhoto[2];

            g[0] = new Gafanhoto("Jubileu", 22, 'M', "Juba");
            g[1] = new Gafanhoto("Creuza", 12, 'F', "Creuzita");

            Visualizacao[] vis = new Visualizacao[5];
            vis[0] = new Visualizacao(g[0],v[2]);
            vis[0].Avaliar();
            Console.WriteLine(vis[0].ToString());
            vis[1] = new Visualizacao(g[0],v[1]);
            vis[1].Avaliar(90.0f);
            Console.WriteLine(vis[1].ToString());
        }
    }
}
