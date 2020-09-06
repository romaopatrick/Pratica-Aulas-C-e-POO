using System;

namespace Ex_3
{
    public class Mamifero : Animal
    {
        private String corPelo;
        public String CorPelo
        {
            get { return corPelo; }
            set { corPelo = value; }
        }

        public override void Alimentar()
        {
            Console.WriteLine("Mamando");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de mamífero");
        }
        public override void Locomover()
        {
            Console.WriteLine("Correndo");
        }
    }
}