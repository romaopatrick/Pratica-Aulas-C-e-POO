using System;

namespace Ex_4
{
    public class Visualizacao
    {
        private Gafanhoto spec;
        public Gafanhoto Spec
        {
            get { return spec; }
            set { spec = value; }
        }
        private Video filme;
        public Video Filme
        {
            get { return filme; }
            set { filme = value; }
        }
        public Visualizacao(Gafanhoto espectador, Video film)
        {
            this.Spec = espectador;
            this.Filme = film;
            this.Spec.TotAssistido++;
            this.Filme.Views++;
        }
        public void Avaliar()
        {
            this.Filme.Avaliacao = (this.Filme.Avaliacao + 5)/2;
        }
        public void Avaliar(int nota)
        {
            this.Filme.Avaliacao = (this.Filme.Avaliacao + nota)/2;
        }
        public void Avaliar(float porc)
        {
            int tot = 0;
            if (porc<=20)
            {   
                tot = 3;
            }
            else if (porc <=50)
            {
                tot = 5;
            }
            else if (porc <=90)
            {
                tot = 8;
            }
            else {tot = 10;}
            this.Filme.Avaliacao = (this.Filme.Avaliacao + tot)/2;
        }
        public override string ToString()
        {
            return "Visualização: \n Nome do Espectador: " + Spec.Nome + "\n Titulo do Video: "
            + Filme.Titulo + "\n Avaliação: " + Filme.Avaliacao;
        }
    }
}