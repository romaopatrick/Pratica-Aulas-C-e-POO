using System;

namespace Ex_3
{
    public class Ave : Animal
    {
        private String corPena;
        public String CorPena
        {
            get { return corPena; }
            set { corPena = value; }
        }

        public override void Alimentar()
        {
            Console.WriteLine("Comendo Plantas");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo Som de Ave");
        }

        public void FazerNinho()
        {
            Console.WriteLine("Ninho Feito");
        }

        public override void Locomover()
        {
            Console.WriteLine("Voando");
        }
    }
}