using System;
namespace Ex_4
{
    public class Video : IVideo
    {
        private string titulo;
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private int avaliacao;
        public int Avaliacao
        {
            get { return avaliacao; }
            set { avaliacao = value ; }
        }
        private int views;
        public int Views
        {
            get { return views; }
            set { views = value; }
        }
        private int curtidas;
        public int Curtidas
        {
            get { return curtidas; }
            set { curtidas = value; }
        }
        private bool reproduzindo;
        public bool Reproduzindo
        {
            get { return reproduzindo; }
            set { reproduzindo = value; }
        }
        public Video(String title)
        {
            this.Titulo=title;
            this.Avaliacao = 5;
            this.Views = 0;
            this.Curtidas = 0;
            this.Reproduzindo = false;
        }
        public string Status()
        {
            return "Video\n{" + "\n Título: " + this.Titulo + "\n Avaliação: " + this.Avaliacao 
            + "\n Views: " + this.Views + "\n Curtidas: " + this.Curtidas + "\n Reproduzindo: "
            + this.Reproduzindo + "\n}";
        }
        public void Play()
        {
            if(this.Reproduzindo==false)
            {
                this.Reproduzindo = true;
            }
            else 
            {
                Console.WriteLine("Video ja está reproduzindo");
            }
        }

        public void Pause()
        {
            if(this.Reproduzindo)
            {
                this.Reproduzindo = false;
            }
            else
            {
                Console.WriteLine("Video ja está pausado");
            }
        }

        public void Like()
        {
            this.Curtidas++;
        }
    }
}