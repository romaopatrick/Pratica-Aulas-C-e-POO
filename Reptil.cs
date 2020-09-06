using System;

namespace Ex_3
{
    public class Reptil : Animal   
    {
        private string corEscama;
        public string CorEscama
        {
            get { return corEscama; }
            set { corEscama = value; }
        }

        public override void Alimentar()
        {
            Console.WriteLine("Comendo Insetos");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de Réptil");
        }

        public override void Locomover()
        {
            Console.WriteLine("Rastejando");
        }
    }
}