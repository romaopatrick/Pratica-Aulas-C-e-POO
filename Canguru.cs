using System;

namespace Ex_3
{
    public sealed class Canguru : Mamifero
    {
        public override void Locomover()
        {
            Console.WriteLine("Saltando");
        }
        public void UsarBolsa()
        {
            Console.WriteLine("Usando bolsa");
        }
    }
}