using System;

namespace Ex_3
{
    public class Peixe : Animal
    {
        private String corEscama;
        public String CorEscama
        {
            get { return corEscama; }
            set { corEscama = value; }
        }

        public override void Alimentar()
        {
            Console.WriteLine("Comendo Algas");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Este peixe não emite som");
        }

        public override void Locomover()
        {
            Console.WriteLine("Nadando");
        }

        public void SoltarBolha()
        {
            Console.WriteLine("Soltando Bolha");   
        }
    }
}